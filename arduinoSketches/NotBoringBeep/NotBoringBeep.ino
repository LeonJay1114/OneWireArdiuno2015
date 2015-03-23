
int speakerPin = 8;

int length = 10000;
const int maxL = 1000;
const int minL = 60;
int L;

void setup() {
  pinMode(speakerPin, OUTPUT);
}


void playTone(int tone, int duration) {
  for (long i = 0; i < duration; i += tone * 2) {
    digitalWrite(speakerPin, HIGH);
    delayMicroseconds(tone);
    digitalWrite(speakerPin, LOW);
    delayMicroseconds(tone);
  }
}

int i = 0;
void loop() {
  if(i >= 3) return;
  L=maxL;
  while(L>minL){
      playTone(L, length);
      L-=10;
  }
  L = minL;
  while(L<maxL){
      playTone(L, length);
      L+=10;
  }
  i++;
}
