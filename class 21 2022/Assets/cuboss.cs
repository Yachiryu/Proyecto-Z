using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboss : MonoBehaviour
{
    public GameObject[] cubo;
    GameObject Cubo;
    public Renderer[] colores;
    Renderer rendo;
    void Start()
    {
        for (int i = 0; i <= 12; i = i + 1)
        {
            cubo[i] = rendo.material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
