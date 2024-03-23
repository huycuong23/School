#include <LiquidCrystal_I2C.h>
#include <Wire.h>
int buttonPin=12;
int ledR4=7;
int ledR3=10;
int ledR2=9;
LiquidCrystal_I2C lcd(0x27, 16, 2);
void setup() {
lcd.init();
lcd.backlight();
pinMode(buttonPin, INPUT);
pinMode(ledR4, OUTPUT);
pinMode(ledR3, OUTPUT);
pinMode(ledR2, OUTPUT);
}

void loop() {
if(digitalRead(buttonPin)==1){
  digitalWrite(ledR4, HIGH);
  delay(2000);
}
else {
  digitalWrite(ledR4, LOW);
  delay(2000);
}
int reading = analogRead(A0);
float voltage = reading * (5000 / 1024.0);

float temperature = voltage / 10;

lcd.print(temperature);

delay(1000);

if(temperature>45){
  digitalWrite(ledR2, HIGH);
}
if(temperature<=45){
  digitalWrite(ledR2, LOW);
}
}