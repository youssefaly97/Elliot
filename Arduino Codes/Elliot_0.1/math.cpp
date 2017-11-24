#include "math.h"

double Adjust_Angle(double x){
  if(x>180) return 360-x;
  return x;
}
 
float Fix_Angle(float x) {
  if(x>1) return 1;
  if(x<-1) return -1;
  return x;
}

int dcmp(float x, float y){
  if(fabs(x-y)<EPS) return 0; //equal
  if(x<y) return -1; // x < y
  return 1; //x > y
}
