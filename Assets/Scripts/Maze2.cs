using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze2 : SwordMan
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

        print("Ã´Ã´Ã´ ÇÏ¸é¼­ ¹ßÀÚ±¹ ¼Ò¸®¸¦ ³À´Ï´Ù");
    }
}
