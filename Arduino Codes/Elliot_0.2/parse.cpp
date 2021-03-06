#include "parse.h"
#include "leg.h"



extern leg legs[4];

//parse serial string to select a command type
void parseCommand(void){
  while(Serial.available()){
    //Serial.println(Serial.available());
    char c = Serial.read();
    if(c == 'C') parseCCommand(Serial.parseInt()); //parse for C commands
    else Serial.read(); //if invalid character, read buffer into nothingness
  }
}

//call C command function
void parseCCommand(uint8_t commandIndex){
  switch(commandIndex){
    case 10: parseLegXYZ(); break;
    case 11: parseLegAngles(); break;
    case 98: collapse(); break;
    case 99: setAll90(); break;
  }
}

//parse remainder of command
void parseLegXYZ(){
  uint8_t l;
  double x,y,z;
  //while(Serial.available()<9);  //l0x1y1z1
  while(Serial.available()){
    char c = Serial.read();
    if(c == ' ') Serial.read();
    else if(c == '\n' || c == '\r') break;
    else if(c == 'L'){l = Serial.parseInt(); x = legs[l].X; y = legs[l].Y; z = legs[l].Z;} //set initial values of x,y & z to keep any unchanged coordinates
    else if(c == 'x') x = Serial.parseFloat();
    else if(c == 'y') y = Serial.parseFloat();
    else if(c == 'z') z = Serial.parseFloat();
    else Serial.read(); //if invalid character, read buffer into nothingness
  }
  Serial.print(l);
  Serial.print('\t');
  Serial.print(x);
  Serial.print('\t');
  Serial.print(y);
  Serial.print('\t');
  Serial.println(z);
  legs[l].moveToPoint(x,y,z);
}

//parse remainder of command
void parseLegAngles(){
  uint8_t l;
  double ca,f,t;
  
  while(Serial.available()){
    char c = Serial.read();
    if(c == ' ') Serial.read();
    else if(c == '\n' || c == '\r') break;
    else if(c == 'L'){l = Serial.parseInt(); ca = legs[l].CoxaAngle; f = legs[l].FemurAngle; t = legs[l].TibiaAngle;}
    else if(c == 'c') ca = Serial.parseFloat();
    else if(c == 'f') f = Serial.parseFloat();
    else if(c == 't') t = Serial.parseFloat();
    else Serial.read(); //if invalid character, read buffer into nothingness
  }
  
  Serial.print(l);
  Serial.print('\t');
  Serial.print(ca);
  Serial.print('\t');
  Serial.print(f);
  Serial.print('\t');
  Serial.println(t);
  legs[l].moveToAngles(ca,f,t);
}

void setAll90(){
  legs[0].moveToAngles(90,90,90);
  legs[1].moveToAngles(90,90,90);
  legs[2].moveToAngles(90,90,90);
  legs[3].moveToAngles(90,90,90);
}

void collapse(){
  for(int i=0; i<4; i++) legs[i].moveToPoint(0,80,80);
  updateLegs(legs[0],legs[1],legs[2],legs[3]);
}

