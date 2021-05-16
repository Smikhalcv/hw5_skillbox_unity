using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplicationTableScript : MonoBehaviour
{
    public Text[] textsTable;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < textsTable.Length; i++)
        {
            textsTable[i].text = "";
            for (int j = 1; j < 11; j++)
            {
                textsTable[i].text += $"{i + 1} * {j} = {(i + 1) * j}\n";
            }
        }
    }
}
