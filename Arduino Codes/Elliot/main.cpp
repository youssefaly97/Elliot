#include <arduino.h>
#include "leg.h"
#include "pins.h"
#include "parse.h"

leg legs[4];

void setup(){
  Serial.begin(115200);
  legs[0] = leg(c0,f0,t0);
  legs[1] = leg(c2,f2,t2);
  legs[2] = leg(c5,f5,t5);
  legs[3] = leg(ca,fa,ta);
}

void loop(){
  double legPos[4][3];
  double X,Y,Z;
  uint8_t L;
  parseLegXYZ(&L,&X,&Y,&Z);
  
  legPos[L][0] = X;
  legPos[L][1] = Y;
  legPos[L][2] = Z;
  
  if(legs[0].moveTo_point(legPos[0][0],legPos[0][1],legPos[0][2]) == -1) Serial.println("out of bounds");
  if(legs[1].moveTo_point(legPos[1][0],legPos[1][1],legPos[1][2]) == -1) Serial.println("out of bounds");
  if(legs[2].moveTo_point(legPos[2][0],legPos[2][1],legPos[2][2]) == -1) Serial.println("out of bounds");
  if(legs[3].moveTo_point(legPos[3][0],legPos[3][1],legPos[3][2]) == -1) Serial.println("out of bounds");
  
  Serial.print(legs[0].CoxaAngle);
  Serial.print('\t');
  Serial.print(legs[0].FemurAngle);
  Serial.print('\t');
  Serial.print(legs[0].TibiaAngle);
  Serial.print("\t\t");

  Serial.print(legs[0].X);
  Serial.print('\t');
  Serial.print(legs[0].Y);
  Serial.print('\t');
  Serial.print(legs[0].Z);
  Serial.print("\t\t\t");

  Serial.print(legs[1].CoxaAngle);
  Serial.print('\t');
  Serial.print(legs[1].FemurAngle);
  Serial.print('\t');
  Serial.print(legs[1].TibiaAngle);
  Serial.print("\t\t");

  Serial.print(legs[1].X);
  Serial.print('\t');
  Serial.print(legs[1].Y);
  Serial.print('\t');
  Serial.print(legs[1].Z);
  Serial.print("\t\t\t");
  
  Serial.print(legs[2].CoxaAngle);
  Serial.print('\t');
  Serial.print(legs[2].FemurAngle);
  Serial.print('\t');
  Serial.print(legs[2].TibiaAngle);
  Serial.print("\t\t");

  Serial.print(legs[2].X);
  Serial.print('\t');
  Serial.print(legs[2].Y);
  Serial.print('\t');
  Serial.print(legs[2].Z);
  Serial.print("\t\t\t");
  
  Serial.print(legs[3].CoxaAngle);
  Serial.print('\t');
  Serial.print(legs[3].FemurAngle);
  Serial.print('\t');
  Serial.print(legs[3].TibiaAngle);
  Serial.print("\t\t");

  Serial.print(legs[3].X);
  Serial.print('\t');
  Serial.print(legs[3].Y);
  Serial.print('\t');
  Serial.print(legs[3].Z);  

  Serial.println();
}

