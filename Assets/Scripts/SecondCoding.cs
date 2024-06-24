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
         
        조건문 
        if(조건식)
        {
        조건이 참일 때 해야할 일
        }
        if (age1 == age2)
        {
            print("age1과 age2의 나이가 같습니다.");
        }
        if(age1 > age2)
        {
            print("age1이 age2보다 나이가 많습니다.");

        }
        if(age1 < age2)
        {
            print("age2가 age1보다 나이가 많습니다.");
        }
        if(age1 != age2)
        {
            print("age1과 age2의 나이가 다릅니다");
        }
      */

        //age1의 나이를 10대부터 40대까지중 어디에 해당하는지 출력
        //예) age1 은 30대 입니다. 
        //if(age1 <20)
        //{
        //    print("age1 은 10대입니다.");
        //}
        //else if(age1 < 30)
        //{
        //    print("age1 은 20대입니다.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1 은 30대입니다.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1 은 40대입니다.");
        //}
        //else 
        //{
        //    print("age1 은 50대 이상입니다.");
        //}
        #endregion
        #region Example 2
        // 1. And 조건
        //만일 성별이 여성이고 나이가 20살 이상일 경우
        //"성인 여성입니다" 출력.
        //if(isMan == false && age1 >=20)
        //{
        //    print("성인 여성입니다");
        //}
        //else
        //{
        //    print("미성년자이거나, 남성입니다");
        //}

        //2. or 조건
        //만일, 움직이는 경우라면 "이동 중입니다"라고 출력하고,
        //그렇지 않으면, "정지한 상태입니다"라고 출력한다
        if(runState == true || walkState == true)
        {
            print("이동 중입니다");
        }
        else
        {
            print("정지한 상태입니다");
        }

        //bool 변수를 조건문의 조건으로 넣었을 때 생략 방법
        //if(runState==false)
        //if(!runState)

        //if(runState == true)
        //if(runState)

        #endregion
        #region 3
        //반복문
        //for(시작 변수 선언및 초기화; 종료조건식; 증감식)
        //{반복해서 수행할 내용}

        //1부터 10까지 모든 정수 출력
        //for(int i = 0; i<10; i = i+1)
        //{
        //    print(i + 1);
        //}
        //1부터 100까지 다 더한 값을 sum이라는 변수에 저장해서 출력한다.
        //for(int i = 0; i<endCount; i++)
        //{
        //    sum += i + 1;

        //}
        //print(sum);
        //누적식
        //int num = 0;
        // num = num + 1;
        // num += 1;
        //num++;
        //num--;

        //1부터 20까지 중에 짝수만 출력한다.
        //for(int i = 0; i<endCount; i++)
        //{
        //    int number = i + 1;
        //    //만일 number를 2로 나눈 나머지가 0이라면(number가 짝수라면)
        //    if(number % 2 == 0)
        //    {
        //        //그 number를 출력
        //        print(number);
        //    }
        //}

        //0부터 endCount 전까지 짝수만 출력한다. 출력된 짝수의 수가 10개에 도달하면 반복을 종료한다
        //0부터 endCount 전까지 반복한다.
        //증가되는 값에서 2로 나눈 나머지가 0인 경우에는 출력한다.
        //printCount변수에 출력한 횟수를 증가시킨다.
        //printCount의 값이 10에 도달하면 종료한다.

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
        //for 문과 if문은 서로 중첩해서 사용이 가능
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
            //\n 줄바꿈
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
