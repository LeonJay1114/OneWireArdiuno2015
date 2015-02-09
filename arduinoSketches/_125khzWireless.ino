#include <SoftwareSerial.h>

SoftwareSerial SoftSerial(9, 8);// Подключение RDM6300 к 8 и 9 пинамArduino Uno

unsigned char buffer[64]; //Описание 64-битного массива буфера

int count=0;//Описание переменной для работы с массивом

void setup(){

SoftSerial.begin(9600);// Запуск RDM6300  

Serial.begin(9600);}//ЗапускСОМ-порта

void loop(){

if (SoftSerial.available()){//Если в RDM6300 есть данные - переписываем из в массив

while(SoftSerial.available()){//Чтение данных из RDM6300

buffer[count++]=SoftSerial.read();//Запись данных в переменную массива

if(count == 64)break; }//Если считали первые 64 бита - обрываем чтение

Serial.write(buffer,count);//Если данных больше нет - записываем значение в порт
clearBufferArray();//Запуск подпрограммы очистки буфера

count = 0;//Обнуление переменной массива

Serial.println();}}//Перевод строки перед записью нового значения

void clearBufferArray(){//Подпрограммаочисткибуфера

for (int i=0; i<count;i++)

{ buffer[i]=NULL;}}//Обнуление ячейки массива
