using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Percent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int MaxScore = 100;
        int score = 59;
        float percent = (float)score / MaxScore;
        print("The score in percentage: " + percent);
    }

    // Update is called once per frame
    
}
