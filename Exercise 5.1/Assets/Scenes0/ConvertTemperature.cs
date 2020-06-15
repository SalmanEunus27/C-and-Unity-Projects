using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int fhTemp = 0;
        Console.WriteLine("Initial Temperature in Fareinheit: " + fhTemp);
        int celTemp = ((fhTemp - 32) / 9) * 5;
        Console.WriteLine("Converted Temperature in Celsius: " + celTemp);
        int fhtempBack = (celTemp * 5) + 32;
        Console.WriteLine("Temperature back to Farenheit again: " + fhtempBack);
    }

    // Update is called once per frame

}
