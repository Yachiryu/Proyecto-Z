using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public string[] jugadores;
    string entrenador = "player";
    void Start()
    {
        for (int i = 0; i <= 10; i = i++)
        {
            jugadores[i] = "player" + (1 + 1).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
