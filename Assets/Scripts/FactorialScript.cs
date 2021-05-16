using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactorialScript : MonoBehaviour
{
    [SerializeField] InputField naturalNumber;

    public void calculationTheFactorial(Text answer)
    {
        long number;
        while (true) // Считывает строку из InputField до тех пор, пока там не будет натрульное число
        {
            try
            {
                number = Convert.ToInt64(naturalNumber.text);
                break;
            }
            catch (System.Exception)
            {
                answer.text = "Укажите натуральное число!";
                throw;
            }
        }

        string result = "1";
        //int answerInt = 1;
        if (number > 0)
        {
            // Стандартный факториал
            //for (int i = 1; i <= number; i++)
            //{
            //    answerInt *= i;
            //}
            //answer.text = answerInt.ToString("### ### ### ### ### ### ###");

            // Факториал через умножение по средствам строк
            MultiplicationThroughStringsScript factorial = new MultiplicationThroughStringsScript();

            //Debug.Log(testNumder.ToString());
            for (int i = 1; i <= number; i++)
            {
                result = factorial.MiltiplicationThroughStrings(result, i.ToString());
            }
            answer.text = result;

        }
        else if (number == 0)
        {
            answer.text = "0";
        }
        else
        {
            answer.text = "Натуральное число больше либо равно 0.";
        }
    }

}
