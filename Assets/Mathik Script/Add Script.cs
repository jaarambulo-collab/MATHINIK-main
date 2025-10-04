using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.UI;

public class AddScript : MonoBehaviour
{
    public UnityEngine.UI.Button[] Options;

    void Start()
    {
        Addition();
        
    }
    public void Addition()
    {
        GameObject[] Object1 = GameObject.FindGameObjectsWithTag("Dog");
        GameObject[] Object2 = GameObject.FindGameObjectsWithTag("Chicken");
        int Object1st = Object1.Length;
        int Object2nd = Object2.Length;
        int sum = Object1st + Object2nd - 2;

        List<int> OptionButtons = new List<int> { sum };

        while (OptionButtons.Count < Options.Length)
        {
            int wrongAnswer = sum + Random.Range(-1, 2);
            wrongAnswer = Mathf.Max(0, wrongAnswer); // Avoid negatives

            if (!OptionButtons.Contains(wrongAnswer))
            {
                OptionButtons.Add(wrongAnswer);
            }
        }
        for (int i = 0; i < OptionButtons.Count; i++)
        {
            int randomIndex = Random.Range(i, OptionButtons.Count);
            int temp = OptionButtons[i];
            OptionButtons[i] = OptionButtons[randomIndex];
            OptionButtons[randomIndex] = temp;
        }
        for (int i = 0; i < Options.Length; i++)
        {
            TMP_Text tmpText = Options[i].GetComponentInChildren<TMP_Text>();
            tmpText.text = OptionButtons[i].ToString();

            bool isCorrect = (OptionButtons[i] == sum);

            Options[i].onClick.RemoveAllListeners();
            Options[i].onClick.AddListener(() => CheckAnswer(isCorrect));
        }
    }
    public void CheckAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            Debug.Log("Correct!");
            
        }
        else
        {
            Debug.Log("Wrong!");
            
        }
    }
}
