using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    //�Լ� ���� ���
    // ��ȯ�ڷ��� �Լ��̸� (�Ű�����..){ �Լ����     }
    //������ ���� �����ϱ�
    public int number = 30;
    public int number3 = 45;
    int numberSum;
    //int remainder;
    //int numberSub;
    //int numberMulti;
    //int numberDivide;
    int result;
    float floatResult;

    string str;

    public float numberFloat1;
    public float numberFloat2;

    float floatSum;
    //�Ǽ��� ���� �����ϱ�
    public float number2;
    //������ ���� �����ϱ�
    public string name;

    string job = "���λ����";
    //���� ���� �����ϱ�
    private bool isMan;
    // Start is called before the first frame update
    void Start()
    {
        //������ ����
        // ���� �̸� = ��;
        //number = 10;
        //number2 = 3.141592f;
        // name = "�����";
        //isMan = true;
        //numberSum = number / number3;
        //remainder = number % number3;
        // floatSum = number + numberFloat1;
        //��Ģ ������ : + - * / %,���ϱ� ���� ���ϱ� �������,������
        //���ڿ�+���ڿ� =>�� ���ڿ��� ����
        //���� �Ǵ� �Ǽ��� ���ڿ��� ����ȯ�ϰ������ : Tostring()
        // string result = name + number.ToString();
        //print(result);
        //number1�� number2������ �հ� ���� ����Ѵ�.
        /*  numberSum = Sum(number, number3);
          numberSub = Sub(number, number3);
          numberMulti = Multi(number, number3);
          numberDivide = Divide(number, number3);

          str = numberSum.ToString();

          print(numberSum);
          print(numberSub);
          print(numberMulti);
          print(numberDivide);
          */
        result= Sum(number, number3);
        print(result);
        result = Sub(number, number3);
        print(result);

        result = Multi(number, number3);
        print(result);

        floatResult = Divide(number, number3);
        print(floatResult);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //�Լ� ����
    //��ȯ �ڷ���, �Լ� �̸�(�Ű�����1, �Ű����� 2,...)
    //{
    //     ����
    //}
    //�� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ���� ���·� ��ȯ�ϴ� �Լ��� �����ʹ�.
     int Sum(int a, int b)
    {
        return a + b;
        
    }
    //�� ������ �Է� �޾Ƽ� �� �� ���� ���� ���� ���� ���·� ��ȯ�ϴ� �Լ�
    int Sub(int a, int b)
    {
        return a - b;
    }
    //�� ������ �Է� �޾Ƽ� �� �� ���� ���� ���� ���� ���·� ��ȯ�ϴ� �Լ�
    int Multi(int a, int b)
    {
        return a * b;
    }
    //�� ������ �Է� �޾Ƽ� �� �� ���� ���� ���� ���� ���·� ��ȯ�ϴ� �Լ�
    float Divide(int a, int b)
    {
        return (float)a /(float) b;
    }

}
