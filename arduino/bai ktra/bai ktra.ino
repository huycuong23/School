int buttonPin = 2;
int led = 9;
void setup() {
  // put your setup code here, to run once:
  pinMode(buttonPin, INPUT);
  pinMode(led, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  int valuebuttonPin = digitalRead(buttonPin);
  if (valuebuttonPin == 1) {
    digitalWrite(led, HIGH);
  }
  
   else {
    digitalWrite(led, LOW);
  }
  delay(1000);
}
