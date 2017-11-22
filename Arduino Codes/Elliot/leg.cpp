//#include <arduino.h>
//#include <Servo.h>
#include "leg.h"
    
leg::leg(){
}
    
leg::leg(uint8_t a, uint8_t b, uint8_t c){
  coxa.attach(a);
  femur.attach(b);
  tibia.attach(c);
  PinCoxa = a;
  PinTibia = b;
  PinFemur = c;
}

void leg::lim(double cm, double cM, double fm, double fM, double tm, double tM){ // a function to set the mechanical constrains of servos
  coxaMin = cm;
  coxaMax = cM;

  femurMin = fm;
  femurMax = fM;

  tibiaMin = tm;
  tibiaMax = tM;
}

void leg::center(double a, double b, double c){ // specify servo centers
   coxaCenter = a;
   femurCenter = b;
   tibiaCenter = c;
}

bool leg::move_tibia_angle(int x){
  if(dcmp(x,tibiaMin) == -1 || dcmp(x,tibiaMax) == 1) return -1; //return -1 if out of bounds
  tibia.write(x);
  return 1;
}

bool leg::move_femur_angle(int x){
  if(dcmp(x,femurMin) == -1 || dcmp(x,femurMax) == 1) return -1; //return -1 if out of bounds
  femur.write(x);
  return 1;
}

bool leg::move_coxa_angle(int x){
  if(dcmp(x,coxaMin) == -1 || dcmp(x,coxaMax) == 1) return -1; //return -1 if out of bounds
  coxa.write(x);
  return 1;
}

bool leg::moveTo_angles(double j, double k, double l){
  if(move_coxa_angle((int)j) == -1) return -1;
  if(move_femur_angle((int)k) == -1) return -1;
  if(move_tibia_angle((int)l) == -1) return -1;
  return 1;
}

bool leg::moveTo_point(double x, double y, double z){ // move to point with IK //https://o...content-available-to-author-only...g.com/inverse-kinematics-and-trigonometry-basics/u
  double l1 = sqrt(x*x+y*y);
  double l = sqrt(z*z+ (l1-Coxa_Length)*(l1-Coxa_Length));
  double t = Tibia_Length;
  double f = Femur_Length;

  CoxaAngle = atan(x*100/(y*100));
  FemurAngle = acos(Fix_Angle(z/l))+acos( Fix_Angle((f*f+l*l-t*t)/(2*f*l)));
  TibiaAngle = acos (Fix_Angle((f*f-l*l+t*t)/(2*f*t)));

  X = x; //actual cordinates are not FK calculated for now
  Y = y;
  Z = z;
  
  return moveTo_angles(Adjust_Angle(degrees(CoxaAngle)+90),Adjust_Angle(degrees(FemurAngle)),Adjust_Angle(degrees(TibiaAngle)));
}
    
bool leg::move_servo_angle(Joint x,int angle){
  switch(x){
    case Coxa: return move_coxa_angle(angle);
    case Femur: return move_femur_angle(angle);
    case Tibia: return move_tibia_angle(angle);
  }
  return 1;
}
/*
void calculateActual(double c, double f, double t){ // calculate actuall coordiantes with FK
  x = 
  y = 
  z = 
}
*/
