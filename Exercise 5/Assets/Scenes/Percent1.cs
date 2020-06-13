using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int MaxScore = 100;
        int score = 59;
        float percent = (float)score / MaxScore;
        Console.WriteLine("The score in percentage: " + percent);
    }

    // Update is called once per frame

}
