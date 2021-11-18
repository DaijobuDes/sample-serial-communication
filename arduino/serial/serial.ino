#include <SoftwareSerial.h>

char data;

void setup() {
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  // Open serial communications and wait for port to open:
  Serial.begin(9600); // 9600 BAUD RATE
    while (!Serial) {
      ; // wait for serial port to connect. Needed for native USB port only
    }
  Serial.print("Hello again");
}
  
void loop() {
  if (Serial.available())
  { 
    data = Serial.read();
    Serial.write(data);
    switch(data)
    {
      case 'a':
        digitalWrite(8, HIGH);
        break;
      case 'b':
        digitalWrite(9, HIGH);
        break;
      case 'c':
        digitalWrite(10, HIGH);
        break;
      case 'd':
        digitalWrite(8, LOW);
        break;
      case 'e':
        digitalWrite(9, LOW);
        break;
      case 'f':
        digitalWrite(10, LOW);
        break;
      default:
        break; 
    }
  } 
}
