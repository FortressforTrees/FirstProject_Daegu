using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    //함수 정의 방법
    // 반환자료형 함수이름 (매개변수..){ 함수기능     }
    //정수형 변수 선언하기
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
    //실수형 변수 선언하기
    public float number2;
    //문자형 변수 선언하기
    public string name;

    string job = "개인사업자";
    //논리형 변수 선언하기
    private bool isMan;
    // Start is called before the first frame update
    void Start()
    {
        //변수의 사용법
        // 변수 이름 = 값;
        //number = 10;
        //number2 = 3.141592f;
        // name = "김기찬";
        //isMan = true;
        //numberSum = number / number3;
        //remainder = number % number3;
        // floatSum = number + numberFloat1;
        //사칙 연산자 : + - * / %,더하기 빼기 곱하기 나누기몫,나머지
        //문자열+문자열 =>두 문자열이 연결
        //정수 또는 실수를 문자열로 형변환하고싶을때 : Tostring()
        // string result = name + number.ToString();
        //print(result);
        //number1과 number2변수의 합계 값을 출력한다.
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
    //함수 선언
    //반환 자료형, 함수 이름(매개변수1, 매개변수 2,...)
    //{
    //     할일
    //}
    //두 정수를 입력 받아서 그 두 수의 합계 값을 정수 형태로 반환하는 함수를 만들고싶다.
     int Sum(int a, int b)
    {
        return a + b;
        
    }
    //두 정수를 입력 받아서 그 두 수의 빼기 값을 정수 형태로 반환하는 함수
    int Sub(int a, int b)
    {
        return a - b;
    }
    //두 정수를 입력 받아서 그 두 수를 곱한 값을 정수 형태로 반환하는 함수
    int Multi(int a, int b)
    {
        return a * b;
    }
    //두 정수를 입력 받아서 그 두 수를 나눈 몫을 정수 형태로 반환하는 함수
    float Divide(int a, int b)
    {
        return (float)a /(float) b;
    }

}
