using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    /*Nombramos los nombres de las variables para controlar la velocidad y hacemos que solo
    sean editables desde el inspector de unity*/
    [SerializeField] private float speedmovement;
    [SerializeField] private Transform[] movementpoints;
    [SerializeField] private float min_distance;

    // Creamos la variable para que se pueda mover de modo random
    private int numeroAleatorio;

    private void Start()
    {
        numeroAleatorio = Random.Range(0, movementpoints.Length);
    }

    // Hacemos que se mueva aleatoriamente por los puntos que creemos
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movementpoints[numeroAleatorio].position, speedmovement * Time.deltaTime);

        if (Vector2.Distance(transform.position, movementpoints[numeroAleatorio].position) < min_distance)
        {
            numeroAleatorio = Random.Range(0, movementpoints.Length);
        }
    }

    /* Hacemos que el movimiento sea en orden y no aleatorio
     numeroAleatorio += 1;
     if(numeroAleatorio >= movementpoints.Length)
     {
       numeroAleatorio = 0;
     }*/
}
