using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    /*Nombramos los nombres de las variables y hacemos que solo
    sean editables desde el inspector de unity*/
    [SerializeField] private float speedmovement;
    [SerializeField] private Transform[] movementpoints;
    [SerializeField] private float min_distance;

    // 
    private int numeroAleatorio;

    private void Start()
    {
        numeroAleatorio = Random.Range(0, movementpoints.Length);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movementpoints[numeroAleatorio].position, speedmovement * Time.deltaTime);

        if (Vector2.Distance(transform.position, movementpoints[numeroAleatorio].position) < min_distance)
        {
            numeroAleatorio = Random.Range(0, movementpoints.Length);
            /*numeroAleatorio += 1;
            if(numeroAleatorio >= movementpoints.Length)
            {
                numeroAleatorio = 0;
            }*/
        }
    }

    // velocidad de la valkirye 4 min distance 1.5
    // velocidad del ninja 5 min distance 3
    // velocidad del caballero 3 min distance 1
    // velocidad del necromancer 4.5 min distance 2
}
