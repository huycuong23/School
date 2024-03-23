void setup() {
  // put your setup code here, to run once:
pinMode(13, OUTPUT);
pinMode(10, OUTPUT);
pinMode(8, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(13, HIGH);
  delay(1000);
  digitalWrite(10, HIGH);
  delay(1000);
  digitalWrite(8, HIGH);
  delay(1000);
}
