using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona_Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Triger para poder detectar los tags y hacer la funcion correspondiente
        if (collision.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
        }
    }

}
