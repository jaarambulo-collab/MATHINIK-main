using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelection : MonoBehaviour
{
    [SerializeField] GameObject Object1;
    [SerializeField] GameObject Object2;
    [SerializeField] GameObject Object3;

    public void Select()
    {
        Object1.SetActive(true);

        if (Object1 == true)
        {
            Object2.SetActive(false);
            Object3.SetActive(false);
        }
    }
}
