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
 
  /*
  //set the initial positions of each leg to XYZ 0,80,80
  for(int i=0; i<4; i++) legs[i].moveToPoint(0,80,80);
 
  //apply the previously set leg positions
  updateLegs(legs[0],legs[1],legs[2],legs[3]);
  */
  legs[0].moveToAngles(90,120,50);
 
  legs[1].moveToAngles(90,120,50);
 
  legs[2].moveToAngles(90,120,50);
 
  legs[3].moveToAngles(90,120,50);
}
 
const int d=250;
void walk(int fr,int fl,int br,int bl){
legs[fl].moveToAngles(90+45,120+30,50);
   delay(d);
 legs[fl].moveToAngles(90,120+30,50);
 delay(d);
 legs[fl].moveToAngles(90,120-10,50+20);
  delay(d);
 legs[fl].moveToAngles(90,120-10,50);
   legs[bl].moveToAngles(90,120-10,50);
      legs[fr].moveToAngles(90-45,120,50);
         legs[br].moveToAngles(90,120,50+20);
          delay(d);
          legs[fl].moveToAngles(90,120,50);
   legs[bl].moveToAngles(90,120,50);
  legs[br].moveToAngles(90,120+30,50);
      delay(d);
  legs[br].moveToAngles(90+45,120+30,50);
  delay(d);
    legs[br].moveToAngles(90+45,120,50);
 
 delay(d);
    legs[fr].moveToAngles(90-45,120+30,50);
 delay(d);
    legs[fr].moveToAngles(90,120+30,50);
  delay(d);
    legs[fr].moveToAngles(90,120-10,50+20);
      delay(d);
      //-10 for weak push
 legs[fl].moveToAngles(90+45,120-10,50);
   legs[br].moveToAngles(90,120-10,50);
      legs[fr].moveToAngles(90,120,50);
         legs[bl].moveToAngles(90,120-10,50+20);
          delay(d);
          //Fix Weak push
           legs[fl].moveToAngles(90+45,120,50);
   legs[br].moveToAngles(90,120,50);
 
   
            legs[bl].moveToAngles(90,120+30,50+20);
            delay(d);
               legs[bl].moveToAngles(90-45,120+30,50);
               delay(d);
                legs[bl].moveToAngles(90-45,120,50);
         delay(d);
 
 
}
 
void rotate(int mode){
int change=45;
if(mode) change*=-1;
  legs[1].moveToAngles(90,150,50);
    legs[3].moveToAngles(90,150,50);
delay(100);
 
    legs[3].moveToAngles(90+change, 150,50);
    legs[1].moveToAngles(90+change,150,50);
   
delay(100);
 legs[3].moveToAngles(90+change, 120,50);
    legs[1].moveToAngles(90+change,120,50);
 delay(100);
     legs[2].moveToAngles(90, 170,50);
    legs[0].moveToAngles(90,170,50);
    delay(100);
     legs[3].moveToAngles(90, 120,50);
    legs[1].moveToAngles(90,120,50);
   delay(100);
       legs[2].moveToAngles(90, 120,50);
    legs[0].moveToAngles(90,120,50);
 
 
}
/*
void loop(){
  walk(0,3,1,2);
  walk(0,3,1,2);
    walk(0,3,1,2);
  walk(0,3,1,2);
  rotate(1);
  delay(500);
 
    rotate(1);
    delay(500);
 
      rotate(1);
      delay(500);
 
        rotate(1);
  delay(1000);
}
*/
void loop(){
  parseCommand();
  //legs[0].Z = 0;
  //Serial.println(legs[0].CoxaAngle);
  updateLegs(legs[0],legs[1],legs[2],legs[3]);
}

