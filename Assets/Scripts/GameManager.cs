using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SwordMan fighter1; 
    SwordMan fighter2;
    SwordMan fighter3;
    Transform trans;
    
    int number = 10;


    // Start is called before the first frame update
    void Start()
    {
        #region ������ ����
        //fighter1 = new SwordMan(50, 5.5f,"���� �˻�");
        //fighter2 = new SwordMan(100, 8.0f,"���� ���� �˻�");
        //fighter3 = new SwordMan(250,13.7f,"���� �� �˻�");

        //fighter1.name = "���� �˻�";
        //fighter1.move();

        
        //fighter2.name = "���� ���� �˻�";
        fighter2.Move();

        //fighter3.name = "���� �� �˻�";
        //fighter3.move();
        #endregion

        #region Ŭ���� �ν��Ͻ� ����
        //fighter.move();
        //fighter.hp = 200;
        //fighter.attackPower = 10;
        //fighter.Attack("�÷��̾�");
        #endregion

       // SwordMan fighter = new SwordMan(200, 10, "�ְ�");
        SwordMan fighter = new SwordMan ();
       // fighter1.healthPoint = 500;
        print(fighter1.healthPoint);
        print(number); //10


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestFunction()
    {
        for(int i = 0; i<3; i++)
        {
            int number1= 0;

            number1 += 10;
            print(number1);

        }
        int number = 0;
        for(int i = 0; 1 < 3; i++)
        {
            number = 0;
            number += 10;
            print(number);
            print(this.number);
        }
    }

    
}
