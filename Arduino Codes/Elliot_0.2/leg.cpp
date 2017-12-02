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

uint8_t leg::moveTibiaAngle(int x){
  if(dcmp(x,tibiaMin) == -1 || dcmp(x,tibiaMax) == 1) return -1; //return -1 if out of bounds
  tibia.write(x);
  return 1;
}

uint8_t leg::moveFemurAngle(int x){
  if(dcmp(x,femurMin) == -1 || dcmp(x,femurMax) == 1) return -1; //return -1 if out of bounds
  femur.write(x);
  return 1;
}

uint8_t leg::moveCoxaAngle(int x){
  if(dcmp(x,coxaMin) == -1 || dcmp(x,coxaMax) == 1) return -1; //return -1 if out of bounds
  coxa.write(x);
  return 1;
}

uint8_t leg::moveToAngles(double j, double k, double l){
  if(moveCoxaAngle((int)j) == -1) return -1;
  CoxaAngle = j; //save angles if not out of bounds
  if(moveFemurAngle((int)k) == -1) return -1;
  FemurAngle = k;
  if(moveTibiaAngle((int)l) == -1) return -1;
  TibiaAngle = l;
  return 1;
}

uint8_t leg::moveToPoint(double x, double y, double z){ // move to point with IK //https://o...content-available-to-author-only...g.com/inverse-kinematics-and-trigonometry-basics/u
  double l1 = sqrt(x*x+y*y);
  double l = sqrt(z*z+ (l1-Coxa_Length)*(l1-Coxa_Length));
  double t = Tibia_Length;
  double f = Femur_Length;

  CoxaAngle = atan(x*100/(y*100));
  FemurAngle = acos(fixAngle(z/l))+acos(fixAngle((f*f+l*l-t*t)/(2*f*l)));
  TibiaAngle = acos (fixAngle((f*f-l*l+t*t)/(2*f*t)));

  X = x; //actual cordinates are not FK calculated for now
  Y = y;
  Z = z;
  
  return moveToAngles(adjustAngle(degrees(CoxaAngle)+90),adjustAngle(degrees(FemurAngle)),adjustAngle(degrees(TibiaAngle)));
}
    
uint8_t leg::moveServoAngle(Joint x,int angle){
  switch(x){
    case Coxa: return moveCoxaAngle(angle);
    case Femur: return moveFemurAngle(angle);
    case Tibia: return moveTibiaAngle(angle);
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
void updateLegs(leg &leg0, leg &leg1, leg &leg2, leg &leg3){
  leg0.moveToPoint(leg0.X,leg0.Y,leg0.Z);
  leg1.moveToPoint(leg1.X,leg1.Y,leg1.Z);
  leg2.moveToPoint(leg2.X,leg2.Y,leg2.Z);
  leg3.moveToPoint(leg3.X,leg3.Y,leg3.Z);
}

