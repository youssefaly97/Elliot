#include <arduino.h>
#include <Servo.h>

#define Femur_Length 92.85
#define Tibia_Length 164.439
#define Coxa_Length 35.056

double Adjust_Angle(double x);
float Fix_Angle(float x);
int dcmp(float x, float y);

class leg{
  private:
    Servo coxa, femur, tibia;
    enum Joint{Coxa, Femur, Tibia};
  public:
    uint8_t PinCoxa, PinTibia, PinFemur;
    double CoxaAngle = 90, TibiaAngle = 90, FemurAngle = 90;
    double coxaMin = 0, coxaMax = 180, femurMin = 0, femurMax = 180, tibiaMin = 0, tibiaMax = 180;
    double coxaCenter = 90, femurCenter = 90, tibiaCenter = 90;
    double X,Y,Z; //actual position
    
    leg(void);
    
    leg(uint8_t a, uint8_t b, uint8_t c);
    void lim(double cm, double cM, double fm, double fM, double tm, double tM);
    void center(double a, double b, double c);
        
    uint8_t move_tibia_angle(int x);
    uint8_t move_femur_angle(int x);
    uint8_t move_coxa_angle(int x);

    uint8_t moveTo_angles(double j, double k, double l);
    uint8_t moveTo_point(double x, double y, double z);
    uint8_t move_servo_angle(Joint x,int angle);

    //void calculateActual(double c, double f, double t);
};
