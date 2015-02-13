#include <SPI.h> 
#include <Servo.h>
#include <OneWire.h>

#define pin  10

enum States {
    wait, check, open, close
}; States state; 

OneWire  ds(pin);

byte tehUID[] = { 0x01, 0xff, 0x40, 0x11, 0x5A, 0x36, 0x00, 0xE1 };

void setup(){
	Serial.begin(9600);
}

void loop(){
switch (state){
	case wait:
	    Waiting();
	    return;
	case check:
		//Checking();
		return;
	case open:
		//Opening();
		return;
	case close:
		//Closing();
		return;
	}
}

void Waiting(){
	byte i;
	byte data[8];

	delay(100); // 1 sec

	ds.reset();
	delay(50);
	ds.write(0x33); // "READ" command

	ds.read_bytes(data, 8);

	Serial.print("KEY ");
	for( i = 0; i < 8; i++) {
		  Serial.print(data[i], HEX);
		    if (i != 7) Serial.print(":");
	}

	// Check if FF:FF:FF:FF:FF:FF:FF:FF
	// If your button is really programmed with FF:FF:FF:FF:FF:FF:FF:FF, then remove this chec
	if (data[0] & data[1] & data[2] & data[3] & data[4] & data[5] & data[6] & data[7] == 0xFF){
		  Serial.println("...nothing found!");
		    return;
	}

}
