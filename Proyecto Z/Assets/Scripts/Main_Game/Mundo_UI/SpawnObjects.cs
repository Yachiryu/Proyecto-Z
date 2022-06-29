using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Array creado para mantener a los enemigos en un solo sitio
    public GameObject[] objects;
    
    // Definimos desde cuando queremos que empiecen a respawnear los enemigos
    public float tiempodelRespawn = 1;
    
    // Cuanto queremos repetir el spawn
    public float repeticiondelRespawn = 3;
     

    // Puntos en los cuales referenciamos los spawn point donde queremos a los enemigos
    public Transform xspawn_Der;
    public Transform xspawn_Izq;

    public Transform yspawn_Up;
    public Transform yspawn_Down;

    void Start()
    {
        //Metodo para hacer que el metodo funcione en el tiempo indicado y repetirlo
        InvokeRepeating("Spawn", tiempodelRespawn, repeticiondelRespawn);
    }

    public void Spawn()
    {
        // Crea el valor random de la derecha y la izquierda. Ademas de dar un valor maximmo y minimo
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        spawnPosition = new Vector3(Random.Range(xspawn_Izq.position.x, xspawn_Der.position.x),
        Random.Range(yspawn_Down.position.y, yspawn_Up.position.y), 0);

        // Accedemos al array creado anteriormente para los enemigos
        GameObject enemie = Instantiate(objects[Random.Range(0,objects.Length)],spawnPosition, gameObject.transform.rotation);
    }
}
