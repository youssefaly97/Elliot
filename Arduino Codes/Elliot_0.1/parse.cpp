#include "parse.h"

void parseLegXYZ(uint8_t *l, double *x, double *y, double *z){
  while(Serial.available()){
    char c = Serial.read();
    if(c == 'l') *l = Serial.parseInt();
    else if(c == 'x') *x = Serial.parseFloat();
    else if(c == 'y') *y = Serial.parseFloat();
    else if(c == 'z') *z = Serial.parseFloat();
    else Serial.read(); //if invalid character, read into nothingness
  }
}

