
// pins for the LEDs:
const int RGB_LED_PINUMBERS[] = { 5, 6, 7 }; // Номера пинов-выходов для RGB-светодиода

bool white = false;		// Состояние светодиода(горит ли), пока находимся в состоянии ожидания карты

void setup() {
  // initialize serial:
  Serial.begin(9600);
}

void loop() {
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
delay(3000);
  // if there's any serial available, read it:
  while (Serial.available() > 0) {
    int red = Serial.parseInt();
  
  
  
    if (Serial.read() == '\n') {
      Serial.print(red, HEX);
    }
  }
  
}








