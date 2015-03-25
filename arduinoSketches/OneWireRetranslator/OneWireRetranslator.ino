/*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

  (Это свободная программа: вы можете перераспространять ее и/или изменять
   ее на условиях Стандартной общественной лицензии GNU в том виде, в каком
   она была опубликована Фондом свободного программного обеспечения; либо
   версии 3 лицензии, либо (по вашему выбору) любой более поздней версии.

   Эта программа распространяется в надежде, что она будет полезной,
   но БЕЗО ВСЯКИХ ГАРАНТИЙ; даже без неявной гарантии ТОВАРНОГО ВИДА
   или ПРИГОДНОСТИ ДЛЯ ОПРЕДЕЛЕННЫХ ЦЕЛЕЙ. Подробнее см. в Стандартной
   общественной лицензии GNU.

   Вы должны были получить копию Стандартной общественной лицензии GNU
   вместе с этой программой. Если это не так, см.
   <http://www.gnu.org/licenses/>.)
*/
#include "OneWire.h"// Библиотека, позволяющая пользоваться протоколом OneWire, не зная протокола OneWire
#define EnterPIN 10
#define ExitPIN 11
const int RelayPIN = 3;
const int ButtonPIN = 2;
const int RGB_LED_PINUMBERS[] = { 5, 6, 7 }; // Номера пинов-выходов для RGB-светодиода
const int NEW_KEY_CHECK_DELAY = 750; // задержка между проверками поднесённости карты в миллисекундах
bool white;		// Состояние светодиода(горит ли), пока находимся в состоянии ожидания карты

OneWire dsEnter(EnterPIN); // использующийся пин отправляется инициализатору класса OneWire
OneWire dsExit(ExitPIN);
byte curKey[9];

int speakerPin = 8;// номер пина управления пищалкой
const int freqLength = 10000;
const int maxT = 1000;
const int minT = 60;
int T;

enum Status{
	read,
	beepAndRead,
	openAndRead
};Status state;

void setup(){
	Serial.begin(9600); // Начать общение с компом по последовательному порту
        pinMode(speakerPin, OUTPUT);
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
	if (!white){// Горим
		digitalWrite(RGB_LED_PINUMBERS[0], HIGH);
		digitalWrite(RGB_LED_PINUMBERS[1], HIGH);
		digitalWrite(RGB_LED_PINUMBERS[2], HIGH);
		white = true;
	}
	else{// Не горим
		digitalWrite(RGB_LED_PINUMBERS[0], LOW); 
		digitalWrite(RGB_LED_PINUMBERS[1], LOW); 
		digitalWrite(RGB_LED_PINUMBERS[2], LOW); 
		white = false;
	}
	
	while(Serial.available()>0){
		switch(Serial.read()){
			case 1:
				state = openAndRead;
				break;
			case 2:
				state = beepAndRead;
				break;
			default:
				state = read;
				break;
                     }
	}

	switch(state){
		case openAndRead:
			DoorOpen();
			state = read;
			break;
		case beepAndRead:
			Beep_Alert();
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


void playTone(int tone, int duration) {
  for (long i = 0; i < duration; i += tone * 2) {
    digitalWrite(speakerPin, HIGH);
    delayMicroseconds(tone);
    digitalWrite(speakerPin, LOW);
    delayMicroseconds(tone);
  }
}
void Beep_Alert(){
          // Желтеем:
	digitalWrite(RGB_LED_PINUMBERS[0], HIGH);   // зажигаем красный
	digitalWrite(RGB_LED_PINUMBERS[1], HIGH);   // зажигаем зелёный
	digitalWrite(RGB_LED_PINUMBERS[2], LOW);   // тушим синий
        delay(500);
        // Краснеем:
	digitalWrite(RGB_LED_PINUMBERS[0], HIGH);   // тушим красный
	digitalWrite(RGB_LED_PINUMBERS[1], LOW);   // тушим зелёный
	digitalWrite(RGB_LED_PINUMBERS[2], LOW);   // тушим синий
	for(int i =0; i<3; i++){
		T=maxT;
		while(T>minT){
		playTone(T, freqLength);
		T-=10;
		}
		T = minT;
		while(T<maxT){
		playTone(T, freqLength);
		      T+=10;
		}
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
  Beep_Good();
  delay(3000);  
  digitalWrite(RelayPIN, LOW);   // реле включено               
}
void Beep_Good()
{
playTone(150,150000);
delay(100);
playTone(150,150000);
delay(100);
playTone(150,150000);
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
