using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntervalScript : MonoBehaviour
{
    [SerializeField] Text outPutText;
    string outPutString = "";

    void Start()
    {
        for (int i = 2; i<10; i+=2)
	        {
                outPutString += $" {i} ";
	        }
        outPutText.text = outPutString;
    }
    
}
