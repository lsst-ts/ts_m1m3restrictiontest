int LED_PIN = 13;    // Pin to indicate the power supply state

void setup() {
  pinMode(LED_PIN, OUTPUT);     // Set the LED pin to OUTPUT
  Serial.begin(9600);           // Start serial communications
}

void loop() {
  if (Serial.available() > 0) {           // If serial data is avaiable read it
    switch(Serial.read()) {
      case '0':                           // Disable power supply output
        digitalWrite(LED_PIN, LOW);
        break;
      case '1':                           // Enable power supply output
        digitalWrite(LED_PIN, HIGH);
        break;
      default:                            // Do nothing
        break; 
    }
  }
}
