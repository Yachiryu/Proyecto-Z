using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subir : MonoBehaviour
{
    public int[] objetos;
    public GameObject forma;
    void Start()
    {
        for (int i = 0; i <=50; i=i+1)
        {
            objetos[i] = i * 2;
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
