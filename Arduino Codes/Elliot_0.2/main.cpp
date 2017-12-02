#include <arduino.h>
#include "leg.h"
#include "pins.h"
#include "parse.h"

leg legs[4]; //create an array of 4 leg objects

void setup(){
  Serial.begin(115200);

  //construct the 4 leg objects with there assigned pins
  legs[0] = leg(c0,f0,t0);
  legs[1] = leg(c1,f1,t1);
  legs[2] = leg(c5,f5,t5);
  legs[3] = leg(ca,fa,ta);

  //set the initial positions of each leg to XYZ 0,80,80
  for(int i=0; i<4; i++){
    legs[i].X = 0;
    legs[i].Y = 80;
    legs[i].Z = 80;
  }

  //apply the previously set leg positions
  updateLegs(legs[0],legs[1],legs[2],legs[3]);
}

void loop(){
  parseCommand();
  updateLegs(legs[0],legs[1],legs[2],legs[3]);
}

