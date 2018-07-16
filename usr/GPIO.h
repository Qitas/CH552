
#define GPIO_INTERRUPT 1
sbit	Power=P1^7;
sbit	KEY0=P1^1;
sbit	KEY1=P1^4;
sbit	KEY2=P1^5;
sbit	KEY3=P1^6;
/*******************************************************************************
* Function Name  : Port1Cfg()
* Description    : �˿�1����
* Input          : Mode  0 = �������룬������
                         1 = �����������
                         2 = ��©���������������
                         3 = ��51ģʽ����©������������������ڲ���·���Լ����ɵ͵��ߵĵ�ƽ����		
                   ,UINT8 Pin	(0-7)											 
* Output         : None
* Return         : None
*******************************************************************************/
void Port1Cfg(UINT8 Mode,UINT8 Pin);
void Port3Cfg(UINT8 Mode,UINT8 Pin);

/*******************************************************************************
* Function Name  : GPIOInterruptCfg()
* Description    : GPIO�ж�����
* Input          : None									 
* Output         : None
* Return         : None
*******************************************************************************/
void GPIOInterruptCfg();
void custom_GPIO_Interrupt(void);
void TheKeyQuery();
void PowerSupplyQuery();
