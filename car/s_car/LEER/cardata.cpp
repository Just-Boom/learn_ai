#include "cardata.h"







void run()
{
  //����ǰ��
  digitalWrite(Left_motor_go, HIGH);    //����ǰ��ʹ��
  digitalWrite(Left_motor_back, LOW);   //�������˽�ֹ
  analogWrite(Left_motor_pwm, c_speed);     //pwm����0-255֮�����������в���

  //�ҵ��ǰ��
  digitalWrite(Right_motor_go, HIGH);   //�ҵ��ǰ��ʹ��
  digitalWrite(Right_motor_back, LOW);  //�ҵ�����˽�ֹ
  analogWrite(Right_motor_pwm, c_speed);    //pwm����0-255֮�����������в���
}
