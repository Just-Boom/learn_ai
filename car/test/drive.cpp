#include<math.h>
#include<stdio.h>
#include <Arduino.h>
#include "drive.h"

const int Left_motor_go = 8;      //左电机前进 AIN1
const int Left_motor_back = 7;       //左电机后退 AIN2
const int Left_motor_pwm = 6;      //左电机控速 PWMA

const int Right_motor_go = 2;       //右电机前进 BIN1
const int Right_motor_back = 4;     //右电机后退 BIN2
const int Right_motor_pwm = 5;     //右电机控速 PWMB

void run(int m_speed)
{
  //左电机前进
  digitalWrite(Left_motor_go, HIGH);    //左电机前进使能
  digitalWrite(Left_motor_back, LOW);   //左电机后退禁止
  analogWrite(Left_motor_pwm, m_speed);     //pwm控速0-255之，左右轮略有差异

  //右电机前进
  digitalWrite(Right_motor_go, HIGH);   //右电机前进使能
  digitalWrite(Right_motor_back, LOW);  //右电机后退禁止
  analogWrite(Right_motor_pwm, m_speed);    //pwm控速0-255之，左右轮略有差异
}

void brake()
{
  //左电机停止
  digitalWrite(Left_motor_go, HIGH);    //左电机停止使能
  digitalWrite(Left_motor_back, HIGH);    
  analogWrite(Left_motor_pwm, 0);     //pwm控速0-255之，左右轮略有差异

  //右电机停止
  digitalWrite(Right_motor_go, HIGH);   //右电机停止使能
  digitalWrite(Right_motor_back, HIGH);   
  analogWrite(Right_motor_pwm, 0);    //pwm控速0-255之，左右轮略有差异
}

void back(int m_speed)
{
  //左电机后退
  digitalWrite(Left_motor_go, LOW);     //左电机前进禁止
  digitalWrite(Left_motor_back, HIGH);  //左电机后退使能
  analogWrite(Left_motor_pwm, m_speed);

  //右电机后退
  digitalWrite(Right_motor_go, LOW);     //右电机前进禁止
  digitalWrite(Right_motor_back, HIGH);  //右电机后退使能
  analogWrite(Right_motor_pwm, m_speed);
}

void left(int m_speed)
{
  //左电机停止
  digitalWrite(Left_motor_go, LOW);     //左电机前进禁止
  digitalWrite(Left_motor_back, LOW);   //左电机后退禁止
  analogWrite(Left_motor_pwm, 0);       //左边电机速度设为0(0-255)

  //右电机前进
  digitalWrite(Right_motor_go, HIGH);  //右电机前进使能
  digitalWrite(Right_motor_back, LOW); //右电机后退禁止
  analogWrite(Right_motor_pwm, m_speed);   //右边电机速度设200(0-255)

  //延时
}

void right(int m_speed)
{
  //左电机前进
  digitalWrite(Left_motor_go, HIGH);    //左电机前进使能
  digitalWrite(Left_motor_back, LOW);   //左电机后退禁止
  analogWrite(Left_motor_pwm, m_speed);     //左边电机速度设200(0-255)

  //右电机停止
  digitalWrite(Right_motor_go, LOW);    //右电机前进禁止
  digitalWrite(Right_motor_back, LOW);  //右电机后退禁止
  analogWrite(Right_motor_pwm, 0);      //右边电机速度设0(0-255)

  //延时

}
