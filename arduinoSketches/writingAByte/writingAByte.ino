#include <OneWire.h>

OneWire  ds(10);

void setup(void) {
  Serial.begin(9600);
}

void loop(){
  byte key = 0x00;
  uint8_t k = 0;
  ds.write(k, 1);
  
}
