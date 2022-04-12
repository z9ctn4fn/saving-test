using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    public Text text;
    private static float number;
    private string numstring;
    void Start()
    {
        numstring = number.ToString();
    }
    public void Increase()
    {
        number++;
    }
    public void Decrease()
    {
        number--;
    }
    public void Update()
    {
        numstring = number.ToString();
        text.text = numstring;
    }
}
