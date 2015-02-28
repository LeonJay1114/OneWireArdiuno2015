#include <OneWire.h>// Библиотека, позволяющая пользоваться протоколом OneWire, не зная протокола OneWire

#define touchPIN 10

const int BUZZER_PINUMBER = 8; // номер пина управления пищалкой
const int NEW_KEY_CHECK_DELAY = 500; // задержка между проверками поднесённости карты в миллисекундах

OneWire ds(touchPIN); // использующийся пин отправляется инициализатору класса OneWire
byte curKey[8];

void setup(){
	Serial.begin(9600); // Начать общение с компом по последовательному порту
}

void loop(){
	delay(NEW_KEY_CHECK_DELAY);

	if(SearchKey()){
		PrintKey();
	}
	
}

bool SearchKey(){
	ds.reset();
	delay(50);
	ds.write(0x33); // "READ" command

	ds.read_bytes(curKey, 8);

	if (curKey[0] & curKey[1] & curKey[2] & curKey[3] & curKey[4] & curKey[5] & curKey[6] & curKey[7] == 0xFF){
		return false;
	}
	return true;
}

void PrintKey(){
	Serial.print("KEY ");
	for(byte i = 0; i < 8; i++) {
		Serial.print(curKey[i], HEX);
	    if (i != 7) Serial.print(":");
	}Serial.println("");
}
