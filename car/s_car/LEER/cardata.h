#ifndef CARDATA_H_INCLUDED
#define CARDATA_H_INCLUDED

class Cardata{

public:
    int c_speed;//��¼С���ٶ�
    int c_state;//��¼С������
    int Left_motor_go = 8;      //左电机前进 AIN1
    int Left_motor_back = 7;       //左电机后退 AIN2
    int Left_motor_pwm = 6;      //左电机控速 PWMA

    int Right_motor_go = 2;       //右电机前进 BIN1
    int Right_motor_back = 4;     //右电机后退 BIN2
    int Right_motor_pwm = 5;     //右电机控速 PWMB

};



#endif // CARDATA_H_INCLUDED
