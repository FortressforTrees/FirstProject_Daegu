using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 15; 
    public int age2 = 7;
    public bool isMan = true;
    public bool runState;
    public bool walkState;
    public int endCount = 100;
    int sum = 0;
    int Count = 0;
    public int printMax = 10;
    string star = "";

    void Start()
    {

        #region Example1
        /*
         
        ���ǹ� 
        if(���ǽ�)
        {
        ������ ���� �� �ؾ��� ��
        }
        if (age1 == age2)
        {
            print("age1�� age2�� ���̰� �����ϴ�.");
        }
        if(age1 > age2)
        {
            print("age1�� age2���� ���̰� �����ϴ�.");

        }
        if(age1 < age2)
        {
            print("age2�� age1���� ���̰� �����ϴ�.");
        }
        if(age1 != age2)
        {
            print("age1�� age2�� ���̰� �ٸ��ϴ�");
        }
      */

        //age1�� ���̸� 10����� 40������� ��� �ش��ϴ��� ���
        //��) age1 �� 30�� �Դϴ�. 
        //if(age1 <20)
        //{
        //    print("age1 �� 10���Դϴ�.");
        //}
        //else if(age1 < 30)
        //{
        //    print("age1 �� 20���Դϴ�.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1 �� 30���Դϴ�.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1 �� 40���Դϴ�.");
        //}
        //else 
        //{
        //    print("age1 �� 50�� �̻��Դϴ�.");
        //}
        #endregion
        #region Example 2
        // 1. And ����
        //���� ������ �����̰� ���̰� 20�� �̻��� ���
        //"���� �����Դϴ�" ���.
        //if(isMan == false && age1 >=20)
        //{
        //    print("���� �����Դϴ�");
        //}
        //else
        //{
        //    print("�̼������̰ų�, �����Դϴ�");
        //}

        //2. or ����
        //����, �����̴� ����� "�̵� ���Դϴ�"��� ����ϰ�,
        //�׷��� ������, "������ �����Դϴ�"��� ����Ѵ�
        if(runState == true || walkState == true)
        {
            print("�̵� ���Դϴ�");
        }
        else
        {
            print("������ �����Դϴ�");
        }

        //bool ������ ���ǹ��� �������� �־��� �� ���� ���
        //if(runState==false)
        //if(!runState)

        //if(runState == true)
        //if(runState)

        #endregion
        #region 3
        //�ݺ���
        //for(���� ���� ����� �ʱ�ȭ; �������ǽ�; ������)
        //{�ݺ��ؼ� ������ ����}

        //1���� 10���� ��� ���� ���
        //for(int i = 0; i<10; i = i+1)
        //{
        //    print(i + 1);
        //}
        //1���� 100���� �� ���� ���� sum�̶�� ������ �����ؼ� ����Ѵ�.
        //for(int i = 0; i<endCount; i++)
        //{
        //    sum += i + 1;

        //}
        //print(sum);
        //������
        //int num = 0;
        // num = num + 1;
        // num += 1;
        //num++;
        //num--;

        //1���� 20���� �߿� ¦���� ����Ѵ�.
        //for(int i = 0; i<endCount; i++)
        //{
        //    int number = i + 1;
        //    //���� number�� 2�� ���� �������� 0�̶��(number�� ¦�����)
        //    if(number % 2 == 0)
        //    {
        //        //�� number�� ���
        //        print(number);
        //    }
        //}

        //0���� endCount ������ ¦���� ����Ѵ�. ��µ� ¦���� ���� 10���� �����ϸ� �ݺ��� �����Ѵ�
        //0���� endCount ������ �ݺ��Ѵ�.
        //�����Ǵ� ������ 2�� ���� �������� 0�� ��쿡�� ����Ѵ�.
        //printCount������ ����� Ƚ���� ������Ų��.
        //printCount�� ���� 10�� �����ϸ� �����Ѵ�.

        //for(int i = 0; i < endCount; i++)
        //{

        //    if(i % 2 == 0)
        //    {
        //        print(i);
        //        Count++;
        //        if (Count >= printMax)
        //        {
        //            break;
        //        }
        //    }
        //}
        //for ���� if���� ���� ��ø�ؼ� ����� ����
        //for(int i = 2; i<10; i++)
        //{
        //    for(int j = 1; j < 10; j++)
        //    {
        //        print(i + "X" + j + "=" + i * j);
        //        //print(i.ToString() + "X" + j.ToString() + "=" + (i*j).ToString());
        //    }

        //}
        #endregion

        #region 4
        /*
         
         *
         **
         ***
         ****
         *****
         
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < i + 1 ;j++)
            {
                star += "*";
            }
            //\n �ٹٲ�
            star += "\n";
        }
        print(star);

         */



        //  for(int i = 0; i < 5; i++)
        //{
        //    star = null;
        //    for(int j = 0; j < i + 1;j++)
        //    {
        //        star += "*";
        //    }
        //    print(star);
        //}
        #endregion

        //Debug.Log("Hello World!");
        //Debug.LogWarning("Hello World!");
        //Debug.LogError("Hello World!");
    }

    void Update()
    {
        
    }
}
