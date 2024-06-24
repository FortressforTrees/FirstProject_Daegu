using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : SwordMan
{


    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Move()
    {
        base.Move();

        print("먼지가 발생합니다");
    }
}
