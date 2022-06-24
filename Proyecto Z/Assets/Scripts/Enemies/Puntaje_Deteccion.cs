using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje_Deteccion : MonoBehaviour
{
    // Determinamos cuantos puntos queremos cuando destruyamos al enemigo o al humano
    public int Score = 0;
    
    /* Hace que unity detecte donde esta dando "Click" el mouse y
       Dar la puntuacion correspondiente del enemigo */
    private void OnMouseDown()
    {
        if (tag == "Enemy")
        {
            Destroy(gameObject);
            Score_UI.score += Score;
        }

        if (tag == "Ally")
        {
            Destroy(gameObject);
            Score_UI.score -= Score;
        }
       
    }



    /* PUNTAJE DE LOS ENEMIGOS Y ALIADOS
    
    ENEMIGOS
    NECROMANCER: 30
    VALKIRYE: 20
    SOLDIER: 15
    MERCENARY: 50

    ALIADOS
    MERCHANT: 10
    MESSENGER: 20
     
     
     
     */

}
