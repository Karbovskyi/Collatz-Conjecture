using System;
using UnityEngine;
using UnityEngine.UI;

public class NumbersInput : IGetRange
{
    private InputField _firstNumber;
    private InputField _lastNumber;

    public NumbersInput(InputField firstNumber, InputField lastNumber)
    {
        _firstNumber = firstNumber;
        _lastNumber = lastNumber;
    }
    
    public (int, int) GetRange()
    {
        int a;
        int b;
        
        bool isA = Int32.TryParse(_firstNumber.text, out a);
        bool isB = Int32.TryParse(_lastNumber.text, out b);

        if (isA && isB && a != 0 && b != 0)
        {
            return a<=b ? (a, b) : (b, a);
        }
        else
        {
            Debug.LogError("IncorrectRange");
            return (1, 1);
        }
    }
}