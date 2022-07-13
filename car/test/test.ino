#include "drive.h"
#include <Servo.h>

/******电机引脚定义******/
const int Left_motor_go = 8;      //左电机前进 AIN1
const int Left_motor_back = 7;       //左电机后退 AIN2
const int Left_motor_pwm = 6;      //左电机控速 PWMA

const int Right_motor_go = 2;       //右电机前进 BIN1
const int Right_motor_back = 4;     //右电机后退 BIN2
const int Right_motor_pwm = 5;     //右电机控速 PWMB

/********行驶状态参数***********/
//设置小车状态参数
int m_speed =100;//初始速度

int m_state = 0;     //方向
String comdata = ""; //用于蓝牙通讯





void setup() {
  // put your setup code here, to run once:
 Serial.begin(9600);   //蓝牙可以当做串口用
 Serial.println("bluetooth.....");

 //初始化电机驱动IO口为输出方式
  pinMode(Left_motor_go, OUTPUT);
  pinMode(Left_motor_back, OUTPUT);
  pinMode(Right_motor_go, OUTPUT);
  pinMode(Right_motor_back, OUTPUT);

}

void loop() { 
  //接收信号
   while(Serial.available()>0){
     //Serial.println((char)Serial.read());     //打印出接收到的数据
        comdata += char(Serial.read());  
        delay(2);  } 

    if(comdata.length()>0){
      
      String a,b;            //用于转换数值类型string至int
      int c,d;
      a = comdata[0];
      b = comdata.substring(1);
      m_state = a.toInt();
      m_speed = b.toInt();
      
      Serial.print(m_speed);//打印数值
      Serial.print(m_state);
      
      switch(m_state){
        case 0:   brake();  break;
        case 1:   run(m_speed);    break;  //判断方向
        case 2:   left(m_speed);   break;
        case 3:   right(m_speed);  break;
        case 4:   back(m_speed);   break;
          } 
    }

       

 
   
  }
