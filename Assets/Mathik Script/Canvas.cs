using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject canvas;

    void Start()
    {
        // Optionally, hide the canvas at the start
        if (canvas != null)
        {
            canvas.SetActive(true);
        }
    }
    
}

