using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Array creado para mantener a los enemigos en un solo sitio
    public GameObject[] enemies;
    
    // Definimos desde cuando queremos que empiecen a respawnear los enemigos
    public float tiempodelRespawn = 1;
    
    // Cuantos segundos queremos repetir el spawn
    public float repeticiondelRespawn = 3;
     

    // Puntos en los cuales referenciamos los spawn point donde queremos a los enemigos
    public Transform spawn_Der;
    public Transform spawn_Izq;

    void Start()
    {
        //Metodo para hacer que el metodo funcione en el tiempo indicado y repetirlo
        InvokeRepeating("SpawnEnemies", tiempodelRespawn, repeticiondelRespawn);


    }

    void Update()
    {
        
    }

    public void SpawnEnemies()
    {
        // Crea el valor random de la derecha y la izquierda 
        Vector3 spawnPosition = new Vector3(0, 0, 0);
      //spawnPosition = new Vector3(Random.Range(spawn_Izq.position.x , spawn_Der.position.x))






    }
}
