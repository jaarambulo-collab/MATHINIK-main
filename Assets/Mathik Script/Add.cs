using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    [SerializeField] InputField input_field;
    public void AddButton()
    {
        string input = input_field.text;
        int number = int.Parse(input);

        if (number == 7)
        {
            Debug.Log("Correct");

        }
        else
        {
            Debug.Log("Wrong");
        }
        

    }
}
