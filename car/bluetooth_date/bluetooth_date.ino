#include <SoftwareSerial.h>

/**
* @par Copyright (C): 2019-2028, Shenzhen Qinhe Intelligent Technology Co.,Ltd.
* @file         advance.c
* @author       George
* @version      V1.0
* @brief        蓝牙数据接收实验
* @details
* @par History  见如下说明
*/

SoftwareSerial BT(8, 9); //新建对象，设置软件串口端口，RX为D8，TX为D9
char val; //存储接收的变量


void setup(){
    Serial.begin(9600); //与PC串口连接
    Serial.println("BT is ready!");
    BT.begin(9600); //设置波特率
}

void loop(){
  while(Serial.available()){
     //Serial.println((char)Serial.read());     //打印出接收到的数据
     for (int i = 0; i < 2; i++)     {   
          flag_run[i] = Serial.read( )-48;       
          delay(5);     } 
          m_state = flag_run[0];//获取运动方向和速度
          m_speed_new = flag_run[1];
          } 
  }
}
