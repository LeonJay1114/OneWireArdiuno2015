#include <OneWire.h>// Библиотека, позволяющая пользоваться протоколом OneWire, не зная протокола OneWire

#define EnterPIN 10
#define ExitPIN 11
const int RelayPIN = 3;
const int ButtonPIN = 2;
const int RGB_LED_PINUMBERS[] = { 5, 6, 7 }; // Номера пинов-выходов для RGB-светодиода
//const int BUZZER_PINUMBER = 8; // номер пина управления пищалкой
const int NEW_KEY_CHECK_DELAY = 750; // задержка между проверками поднесённости карты в миллисекундах
bool white;		// Состояние светодиода(горит ли), пока находимся в состоянии ожидания карты

OneWire dsEnter(EnterPIN); // использующийся пин отправляется инициализатору класса OneWire
OneWire dsExit(ExitPIN);
byte curKey[9];

enum Status{
	read,
	openAndRead
};Status state;

void setup(){
	Serial.begin(9600); // Начать общение с компом по последовательному порту
        pinMode (RelayPIN, OUTPUT);
        pinMode (ButtonPIN, INPUT);
        // активируем на выход пины для RGB-лампочки:
	pinMode(RGB_LED_PINUMBERS[0], OUTPUT); // red
	pinMode(RGB_LED_PINUMBERS[1], OUTPUT); // green
	pinMode(RGB_LED_PINUMBERS[2], OUTPUT); // blue
        white = false; // До начала работы светодиод не горит
	state = read;
}

void loop()       {
	if (!white){
		digitalWrite(RGB_LED_PINUMBERS[0], HIGH);   // зажигаем светодиод
		digitalWrite(RGB_LED_PINUMBERS[1], HIGH);   // зажигаем светодиод
		digitalWrite(RGB_LED_PINUMBERS[2], HIGH);   // зажигаем светодиод
		white = true;
	}
	else{
		digitalWrite(RGB_LED_PINUMBERS[0], LOW);   // зажигаем светодиод
		digitalWrite(RGB_LED_PINUMBERS[1], LOW);   // зажигаем светодиод
		digitalWrite(RGB_LED_PINUMBERS[2], LOW);   // зажигаем светодиод
		white = false;
	}
	
	while(Serial.available()>0){
		if(Serial.read() == 1)
			state = openAndRead;
		else
			state = read;
	}

	switch(state){
		case openAndRead:
			DoorOpen();
			state = read;
			break;
		case read:
			break;
	}
	 
	delay(NEW_KEY_CHECK_DELAY);
	if(SearchEnterKey()){
		PrintKey();
	}

	delay(NEW_KEY_CHECK_DELAY);
	if(SearchExitKey()){
		PrintKey();
	}
    if(digitalRead(ButtonPIN)){
		DoorOpen();
    }
}
void DoorOpen()
{
        // Желтеем:
	digitalWrite(RGB_LED_PINUMBERS[0], HIGH);   // зажигаем красный
	digitalWrite(RGB_LED_PINUMBERS[1], HIGH);   // зажигаем зелёный
	digitalWrite(RGB_LED_PINUMBERS[2], LOW);   // тушим синий
        delay(500);
        // Зеленеем:
	digitalWrite(RGB_LED_PINUMBERS[0], LOW);   // тушим красный
	digitalWrite(RGB_LED_PINUMBERS[1], HIGH);   // зажигаем зелёный
	digitalWrite(RGB_LED_PINUMBERS[2], LOW);   // тушим синий
  digitalWrite(RelayPIN, HIGH);  // реле выключено
  delay(3000);  
  digitalWrite(RelayPIN, LOW);   // реле включено               
}

bool SearchEnterKey(){
	dsEnter.reset();
	delay(50);
	dsEnter.write(0x33); // "READ" command

	dsEnter.read_bytes(curKey, 8);

	if (curKey[0] & curKey[1] & curKey[2] & curKey[3] & curKey[4] & curKey[5] & curKey[6] & curKey[7] == 0xFF){
		return false;
	}
	curKey[8] = 0;
	return true;
}

bool SearchExitKey(){
	dsExit.reset();
	delay(50);
	dsExit.write(0x33); // "READ" command

	dsExit.read_bytes(curKey, 8);

	if (curKey[0] & curKey[1] & curKey[2] & curKey[3] & curKey[4] & curKey[5] & curKey[6] & curKey[7] == 0xFF){
		return false;
	}
	curKey[8] = 1;
	return true;
}


void PrintKey(){
	for(byte i = 0; i < 9; i++) {
		Serial.print((char)curKey[i]);
	}
}
