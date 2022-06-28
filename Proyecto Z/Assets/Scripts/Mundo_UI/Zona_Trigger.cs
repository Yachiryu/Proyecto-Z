using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Vidas : MonoBehaviour
{
    public GameObject[] Health;
    public int Point_Heal;
    //public GameObject[] Enemy;

    private void Update()
    {
        if (Point_Heal < 1)
        {
            Destroy(Health[0].gameObject);
        }

        else if (Point_Heal < 2)
        {
            Destroy(Health[1].gameObject);
        }

        else if (Point_Heal < 3)
        {
            Destroy(Health[2].gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Triggers para poder detectar los tags y hacer la funcion correspondiente al llegar al final de la zona
        
        if (collision.tag == "Enemy") 
        {
            Destroy(collision.gameObject);
            Score_UI.score -= 50;
            Point_Heal--;
        }

        if (collision.tag == "Enemy2")
        {
            Destroy(collision.gameObject);
            Score_UI.score -= 100;
            Point_Heal --;
        }

        if (collision.tag == "Ally")
        {
            Destroy(collision.gameObject);
            Score_UI.score += 25;
            Point_Heal ++;
        }
    }

}
