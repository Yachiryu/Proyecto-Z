using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    // Array creado para mantener a los enemigos en un solo sitio
    public GameObject[] objects;
    
    // Definimos desde cuando queremos que empiecen a respawnear los enemigos
    public float tiempodelRespawn = 2;
    
    // Cuanto queremos repetir el spawn
    public float repeticiondelRespawn = 3;

    public float tiempodificultad = 0;
     

    // Puntos en los cuales referenciamos los spawn point donde queremos a los enemigos
    public Transform xspawn_Der;
    public Transform xspawn_Izq;

    public Transform yspawn_Up;
    public Transform yspawn_Down;

    
    void Start()
    {
        StartCoroutine("dificulty");
    }
   
    // Dificultades
    private void Update()
    {
        tiempodificultad += Time.deltaTime;

        if (tiempodificultad > 20 && tiempodificultad < 30)
        {
            repeticiondelRespawn = 2.75f;
        }

        if (tiempodificultad > 30 && tiempodificultad < 40)
        {
            repeticiondelRespawn = 2f;
        }

        if (tiempodificultad > 40 && tiempodificultad < 50)
        {
            repeticiondelRespawn = 1.75f;
        }

        if (tiempodificultad > 60)
        {
            repeticiondelRespawn = 0.65f;
        }

    }

    IEnumerator dificulty() 
    {
        yield return new WaitForSeconds(repeticiondelRespawn);
        Spawn();
        StartCoroutine("dificulty");
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
