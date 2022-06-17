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
    private int nextStep = 0;

    private void Start()
    {
        nextStep = Random.Range(0, movementpoints.Length);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movementpoints[nextStep].position, speedmovement * Time.deltaTime);

        if (Vector2.Distance(transform.position, movementpoints[nextStep].position) < min_distance)
        {
            //nextStep = Random.Range(0, movementpoints.Length);
            nextStep += 1;
            if(nextStep >= movementpoints.Length)
            {
                nextStep = 0;
            }
        }
    }

    // velocidad de la valkirye 4 min distance 1.5
    // velocidad del ninja 5 min distance 2
    // velocidad del caballero 5 min distance 2
}
