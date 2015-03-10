#include <OneWire.h>// Библиотека, позволяющая пользоваться протоколом OneWire, не зная протокола OneWire

#define EnterPIN 10
#define ExitPIN 11

//const int BUZZER_PINUMBER = 8; // номер пина управления пищалкой
const int NEW_KEY_CHECK_DELAY = 750; // задержка между проверками поднесённости карты в миллисекундах

OneWire dsEnter(EnterPIN); // использующийся пин отправляется инициализатору класса OneWire
OneWire dsExit(ExitPIN);
byte curKey[9];


void setup(){
	Serial.begin(9600); // Начать общение с компом по последовательному порту
}

void loop(){
	delay(NEW_KEY_CHECK_DELAY);
	if(SearchEnterKey()){
		PrintKey();
	}

	delay(NEW_KEY_CHECK_DELAY);
	if(SearchExitKey()){
		PrintKey();
	}
	
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
