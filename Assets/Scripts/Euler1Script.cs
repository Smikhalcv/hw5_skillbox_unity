using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Euler1Script : MonoBehaviour
{
    [SerializeField] Text outPutText;
    int sum = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
        outPutText.text = sum.ToString();
    }

}
