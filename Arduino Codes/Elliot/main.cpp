#include "leg.h"
#include "pins.h"
#include "parse.h"

leg legs[4];

int main(){
  legs[0] = leg(c0,f0,t0);
  legs[1] = leg(c2,f2,t2);
  legs[2] = leg(c5,f5,t5);
  legs[3] = leg(ca,fa,ta);
  
  while(1){
    static double x,y,z;
    static uint8_t l;
    parseLegXYZ(&l,&x,&y,&z);
    if(legs[l].moveTo_point(x,y,z) == -1) Serial.println("out of bounds");
  }
}

