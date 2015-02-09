/*
	<Программа контроллера модели системы СКУД на Arduino. Использует buzzer, RGBLED и RFID-reader>
	Copyright (C) <2014>  <Ilyin I.I. Zubov Y.M.>
	
	This program is free software; you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation; either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program; if not, write to the Free Software Foundation,
	Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301  USA
*/

#include <SPI.h>	// стандартная в Arduino IDE библиотека для работы с SPI шиной. Шта? https://ru.wikipedia.org/wiki/Serial_Peripheral_Interface
#include <Servo.h>  // стандартная в Arduino IDE библиотека для управления сервомоторчиком
#include <MFRC522.h> // Хэдер с одноимённым классом для управления РЧИ-читалкой. Шта? https://github.com/miguelbalboa/rfid

#include <stdlib>

// Номера пинов управления РЧИ-читалкой
#define SS_PIN 10
#define RST_PIN 9

using namespace std;

const int RGB_LED_PINUMBERS[] = { 5, 6, 7 }; // Номера пинов-выходов для RGB-светодиода
const int SERVO_PINUMBER = 3; // Номер пина управления сервомоторчиком
const int BUZZER_PINUMBER = 4; // номер пина управления пищалкой
const int BUTTON_PINUMBER = 2;     // номер входа, подключенный к кнопке

const int NEW_CARD_CHECK_DELAY = 500; // задержка между проверками поднесённости карты в милисекундах
const int OPEN_CLOSE_DELAY = 3000; // задержка между открытием и закрытием

const byte tehUID[4] = { 0x33, 0xFF, 0x6B, 0x9A }; // tehUID карты, на котороую реагируем положительно

bool buttonState = 0; // переменная для хранения состояния кнопки

enum States { // Состояния контроллера:
	wait, check, open, close
}; States state; // текущее состояние

bool rightCard; // Для запоминания в цикле проверки верности карты, верна ли она
bool white;		// Состояние светодиода(горит ли), пока находимся в состоянии ожидания карты
int pos = 0;	// Положение ротора сервомотора (градусы)

Servo myservo; // Экземпляр Servo для управления сервомотором

MFRC522 mfrc522(SS_PIN, RST_PIN); // Экземпляр MFRC522 для управления РЧИ-ридером.

void setup() {
	Serial.begin(9600);	// Начать общение с компом по последовательному порту
	SPI.begin();			// Инициализация SPI-шины. 
	mfrc522.PCD_Init();	// Инициализация РЧИ-читалки
	myservo.attach(SERVO_PINUMBER);	// Инициализация управляющего сервоприводом объекта с указанием пина для работы

	Serial.println("Scan PICC to see UID and type..."); // разговариваем с портом, ага.

	white = false; // До начала работы светодиод не горит
	state = wait; // Работа начинается с состояния ожидания

	// активируем на выход пины для RGB-лампочки:
	pinMode(RGB_LED_PINUMBERS[0], OUTPUT); // red
	pinMode(RGB_LED_PINUMBERS[1], OUTPUT); // green
	pinMode(RGB_LED_PINUMBERS[2], OUTPUT); // blue

	pinMode(BUZZER_PINUMBER, OUTPUT); // активируем на выход пин для гудка
	pinMode(BUTTON_PINUMBER, INPUT); //активируем пин на вход, ждем кнопку
}


void loop() {
  	delay(NEW_CARD_CHECK_DELAY);

	/// мигаем белым:
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

      	// проверяем наличие новой карты:
	if (!mfrc522.PICC_IsNewCardPresent()) return;
      // Желтеем:
	digitalWrite(RGB_LED_PINUMBERS[0], HIGH);   // зажигаем красный
	digitalWrite(RGB_LED_PINUMBERS[1], HIGH);   // зажигаем зелёный
	digitalWrite(RGB_LED_PINUMBERS[2], LOW);   // тушим синий
	
	// Считываем UID одной из поднесённых карточек
	if (!mfrc522.PICC_ReadCardSerial()) {
		return;
	}
	delay(500);
      
        char* buff = new char[10];
        itoa(40, buff, 16);
        for(int i =0; i<4; i++)
          Serial.println(mfrc522.uid.uidByte[i], HEX);  // print as an ASCII-encoded hexadecimal
  
}

/*
	Программа написана для работы, выполненной из любопытства и, по схождению звёзд, для участия
	в конференции БИП 2014.
	Код распространяется под лицензией GPLv3. На здоровье.
	Текст лицензии: http://www.gnu.org/licenses/gpl-3.0.html
*/
