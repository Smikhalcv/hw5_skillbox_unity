using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationThroughStringsScript : MonoBehaviour
{
    /// <summary>
    /// Воспринимает на вход два числа в виде строк
    /// и реализует их умножение в столбик. 
    /// На выходе результат представлен строкой.
    /// </summary>
    /// <param name="firstNum">Первый параметр - string</param>
    /// <param name="secondNum">Второй параметр - string</param>

    public string MiltiplicationThroughStrings(string firstNum, string secondNum)
    {
        string[] arrayNumStr = new string[secondNum.Length]; // Создаёт массив, с количество элементов равных длине второго параметра

        for (int i = 0; i < arrayNumStr.Length; i++) // Заполняет массив
        {
            arrayNumStr[i] = "";
            for (int k = 0; k < i; k++) // Для выполнения умножения в столбик дополняет строку нолями
            {
                arrayNumStr[i] += "0";
            }
            int dozen = 0; // Переходные десятки 

            for (int j = 0; j <= firstNum.Length; j++) // Читает посимвольно переданные параметры, конвертируя их в числа и перемножает
            {
                int firstMultiplier = 0;
                try
                {
                    firstMultiplier = Convert.ToInt32(firstNum[firstNum.Length - 1 - j].ToString());
                }
                catch (Exception)
                { }
                int secondMultiplier = 0;
                try
                {
                    secondMultiplier = Convert.ToInt32(secondNum[secondNum.Length - 1 - i].ToString());
                }
                catch (Exception)
                { }
                int product = firstMultiplier * secondMultiplier;
                product += dozen;
                dozen = product / 10;
                arrayNumStr[i] = arrayNumStr[i].Insert(0, (product % 10).ToString());
            }
        }

        // Суммирует элементы массива после их произведения реализуя умножение в столбик
        int caunter = arrayNumStr[arrayNumStr.Length - 1].Length;
        string result = "";
        int dozenSum = 0;
        for (int i = caunter - 1; i > -1; i--) // итерируется по последнему члену массива arrayNumStr начиная с конца
        {
            int sum = 0 + dozenSum;
            for (int j = 0; j < arrayNumStr.Length; j++) // итерируется по количесвтву членов в массиве arrayNumStr
            {
                int increment = 0;
                try // Проверяет наличие элемента, если нет, пустое место приравнивает к 0
                {
                    increment = Convert.ToInt32(arrayNumStr[j][i - (caunter - arrayNumStr[j].Length)].ToString());
                }
                catch (Exception)
                { }
                sum += increment;
            }
            dozenSum = sum / 10;
            result = result.Insert(0, (sum % 10).ToString());

        }

        if (result[0] == '0') // Удаляет 0 если он стоит в начале числа
        {
            result = result.Remove(0, 1);
        }
        Debug.Log($"result = {result}");
        return result;
    }


}



