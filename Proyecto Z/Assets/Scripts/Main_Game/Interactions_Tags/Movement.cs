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
    //private int numeroAleatorio;
    private int siguiente_paso;

    private void Start()
    {
        //numeroAleatorio = Random.Range(0, movementpoints.Length);
    }

    private void Update()
    {
        // Hacemos que el movimiento sea en orden y no aleatorio

        transform.position = Vector2.MoveTowards(transform.position, movementpoints[siguiente_paso].position, speedmovement * Time.deltaTime);

        if (Vector2.Distance(transform.position, movementpoints[siguiente_paso].position) < min_distance && tag == "Enemy")
        {
            siguiente_paso += 1;
            if (siguiente_paso >= movementpoints.Length)
            {
                siguiente_paso = 0;
            }
        }

        // Hacemos que se mueva aleatoriamente por los puntos que creemos

        if (Vector2.Distance(transform.position, movementpoints[siguiente_paso].position) < min_distance && tag == "Enemy2")
        {
            siguiente_paso = Random.Range(0, movementpoints.Length);
        }

        if (Vector2.Distance(transform.position, movementpoints[siguiente_paso].position) < min_distance && tag == "Ally")
        {
            siguiente_paso = Random.Range(0, movementpoints.Length);
        }

    }




   
    
}
