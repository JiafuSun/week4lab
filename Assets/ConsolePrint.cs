using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i = 3;

    void Start()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
    }

    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
    }
}
