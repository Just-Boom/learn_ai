int Left_motor_go = 8;      //左电机前进 AIN1
int Left_motor_back = 7;       //左电机后退 AIN2
int Left_motor_pwm = 6;      //左电机控速 PWMA

int Right_motor_go = 2;       //右电机前进 BIN1
int Right_motor_back = 4;     //右电机后退 BIN2
int Right_motor_pwm = 5;     //右电机控速 PWMB


int flag_run = 0;

int m_speed =100;




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

void run()
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

void back()
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

void left()
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

void right()
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


void loop() {
  // put your main code here, to run repeatedly:
   while(Serial.available()){
     //Serial.println((char)Serial.read());     //打印出接收到的数据
     flag_run = Serial.read()-48;
     }
  switch(flag_run){
        case 0:   brake();  break;
        case 1:   run();    break;
        case 2:   left();   break;
        case 3:   right();  break;
        case 4:   back();   break;
        case 5:   run(); m_speed = m_speed++ ; break;
        case 6:   run(); m_speed = m_speed-- ; break;
        default : brake();  break;    
    }
  }
