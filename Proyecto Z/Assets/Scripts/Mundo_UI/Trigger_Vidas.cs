using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona_Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Triggers para poder detectar los tags y hacer la funcion correspondiente al llegar al final de la zona
        
        if (collision.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
            Score_UI.score -= 50;
        }

        if (collision.tag == "Enemy2")
        {
            Destroy(collision.gameObject);
            Score_UI.score -= 100;
        }

        if (collision.tag == "Ally")
        {
            Destroy(collision.gameObject);
            Score_UI.score += 25;
        }
    }

}
