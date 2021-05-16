using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Euler2Script : MonoBehaviour
{
    [SerializeField] Text outPutText;
    int sum = 2;
    List<int> fibonuchee = new List<int> () {1, 2};
    int maxValue = 4000000;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; fibonuchee[i - 1] + fibonuchee[i - 2] < maxValue; i++)
        {
            fibonuchee.Add(fibonuchee[i - 1] + fibonuchee[i - 2]);
            if (fibonuchee[i] % 2 == 0)
            {
                sum += fibonuchee[i];
            }
        }

        outPutText.text = sum.ToString();
    }
}
