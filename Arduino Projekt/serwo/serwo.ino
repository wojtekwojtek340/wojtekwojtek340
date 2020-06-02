#include <Servo.h>

#define przycisk1 2
#define przycisk2 3
#define przycisk3 4
#define przycisk4 5
#define przycisk5 6
#define serwo1PWM 9
#define serwo2PWM 10
#define dioda1 11
#define dioda2 12
#define dioda3 13
#define potencjometr1 A0
#define potencjometr2 A1

Servo serwo1;
Servo serwo2;
int tab[2][10];
int count = 0;
bool servoBreak = false;

//////////////////////|/////////////////////////|/////////////////////////////////
//////////////////////|/////KONFIGURACJA////////|/////////////////////////////////
//////////////////////V///////FUNKCJE///////////V/////////////////////////////////


void setup()
{
  Serial.begin(9600);
  pinMode(potencjometr1, INPUT);
  pinMode(potencjometr2, INPUT);
  pinMode(przycisk1, INPUT_PULLUP);
  pinMode(przycisk2, INPUT_PULLUP);
  pinMode(przycisk3, INPUT_PULLUP);
  pinMode(przycisk4, INPUT_PULLUP);
  pinMode(przycisk5, INPUT_PULLUP);
  pinMode(dioda1,OUTPUT);
  pinMode(dioda2,OUTPUT);
  pinMode(dioda3,OUTPUT);  
}

void servoOn()
{
  serwo1.attach(serwo1PWM);
  serwo2.attach(serwo2PWM);
}

void servoOff()
{
  serwo1.detach();
  serwo2.detach();
}

void moveSerialPort()
{
  int flaga = 0;
  while (Serial.available() > 0)
  {
    int incomingByte = 0;
    incomingByte = Serial.parseInt();
    if (incomingByte > 0 && flaga == 0)
    {
      softMove(serwo1, incomingByte, 50);
      flaga = 1;
      int servoPos = serwo1.read();
      delay(50);
    }
    else if (incomingByte > 0 && flaga == 1)
    {
      softMove(serwo2, incomingByte, 20);
      flaga = 0;
      int servoPos = serwo2.read();
      delay(50);
    }
  }
}

void softMove(Servo &serwo, int writePos, int timee)
{
  bool x = true;
  int readPos = serwo.read();
  while (x)
  {
    if (readPos <= writePos)
    {
      for (int i = readPos; i <= writePos; i++)
      {
        serwo.write(i);
        delay(timee);
        x = false;
      }
    }
    else if (readPos > writePos)
    {
      for (int i = readPos; i >= writePos; i--)
      {
        serwo.write(i);
        delay(timee);
        x = false;
      }
    }
  }
}

void smartMove()
{
  for(int i = 0; i < count; i++)
  {
    softMove(serwo1, tab[0][i], 50);
    softMove(serwo2, tab[1][i], 20);    
  }
}

void teach()
{
 while(digitalRead(przycisk1) == HIGH)
 {
  servoOff();
  
  if(digitalRead(przycisk2) == LOW)
  {
   digitalWrite(dioda2, HIGH);
   delay(200);
   int pot1Count = (int)(analogRead(potencjometr1) - 62.46) / 2.95;
   int pot2Count = (int)(analogRead(potencjometr2) - 178.2) / 3.89;
   tab[0][count] = pot1Count;
   tab[1][count] = pot2Count;
   count++;
   digitalWrite(dioda2, LOW);
  }

  else if(digitalRead(przycisk3) == LOW)
  {
    attachInterrupt(digitalPinToInterrupt(przycisk2), serwoStop, LOW);
    delay(200);
    servoOn();
    while(servoBreak == false)
    {
     digitalWrite(dioda2, HIGH);
     smartMove();  
    }
    servoBreak = false; 
    detachInterrupt(digitalPinToInterrupt(przycisk2));
    digitalWrite(dioda2, LOW);   
  }
  
  else if(digitalRead(przycisk1) == LOW)
  {
   delay(200);
   clearTable();
   break;  
  }
 }
}

void clearTable()
{
  for(int i = 0; i<count;i++)
  {
    tab[0][i] = 0;
    tab[1][i] = 0;
  }
  count = 0;
}

void serwoStop()
{
  servoOff();
  servoBreak = true;
  servoOn();
}

void homePos()
{
  softMove(serwo1, 90, 50);
  softMove(serwo2, 90, 20);  
}

void customMove()
{
  while(digitalRead(przycisk3) == HIGH)
  {
    int posSer1 = serwo1.read();
    int posSer2 = serwo2.read();
    if(digitalRead(przycisk1) == LOW)
    {
      delay(200);
      while(digitalRead(przycisk1) == HIGH)
      {
        posSer1 += 1;
        softMove(serwo1, posSer1, 50);

        if(posSer1 > 180)
        break;
      }
      delay(200);
    }
        
    else if(digitalRead(przycisk2) == LOW)
    {
      delay(200);
      while(digitalRead(przycisk2) == HIGH)
      {
        posSer1 -= 1;
        softMove(serwo1, posSer1, 50);

        if(posSer1 < 0)
        break;
      }
      delay(200);
    }
    
    else if(digitalRead(przycisk4) == LOW)
    {
      delay(200);
      while(digitalRead(przycisk4) == HIGH)
      {
        posSer2 += 1;
        softMove(serwo2, posSer2, 30);

        if(posSer2 > 180)
        break;
      }
      delay(200);
    }
    
    else if(digitalRead(przycisk5) == LOW)
    {
      delay(200);
      while(digitalRead(przycisk5) == HIGH)
      {
        posSer2 -= 1;
        softMove(serwo2, posSer2, 30);

        if(posSer2 < 0)
        break;
      }
      delay(200);
    }
    
    else if(digitalRead(przycisk3) == LOW)
    {
      delay(200);
      break;  
    }
  }
  delay(200);
}

//////////////////////|/////////////////////////|/////////////////////////////////
//////////////////////|/////VOID///////LOOP/////|/////////////////////////////////
//////////////////////V/////////////////////////V/////////////////////////////////

void loop()
{
  digitalWrite(dioda1, LOW);
  digitalWrite(dioda2, LOW);
  digitalWrite(dioda3, LOW);
  servoOn();
  if(digitalRead(przycisk1) == LOW)
  {
    delay(200);
    digitalWrite(dioda1, HIGH);        
    teach();
    digitalWrite(dioda1, LOW);  
  }
  else if(digitalRead(przycisk2) == LOW)
  {
    delay(200);
    digitalWrite(dioda2, HIGH);    
    moveSerialPort();
    digitalWrite(dioda2, LOW); 
  }
  else if(digitalRead(przycisk3) == LOW)
  {
    delay(200);
    digitalWrite(dioda2, HIGH);
    customMove();
    digitalWrite(dioda2, LOW);
  }
  else if(digitalRead(przycisk4) == LOW)
  {
    delay(200);
    homePos();
  }
}
