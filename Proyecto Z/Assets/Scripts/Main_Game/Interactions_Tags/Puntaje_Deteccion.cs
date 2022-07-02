using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntaje_Deteccion : MonoBehaviour
{
    // Determinamos cuantos puntos queremos cuando destruyamos al enemigo o al humano
    // Y la vida que tendra al morir, y laanimacion a ejecutar
    public int Score = 0;
    public int num_Clicks;
    private int vida_Aliado = 3;
    public Animator animacion;

    /* Hace que unity detecte donde esta dando "Click" el mouse y
       Dar la puntuacion correspondiente del enemigo */
    public void GameOver()
    {
        SceneManager.LoadScene("Game_Over");
    }
    private void OnMouseDown()
    {
        if (tag == "Enemy")
        {
            num_Clicks --;
            if (num_Clicks == 0)
            {
                GetComponent<AudioSource>().enabled = true;
                GetComponent<Movement>().enabled = false;
                animacion.SetBool("Muerte_Anim",true);
                Destroy(gameObject,2f);
                Score_UI.score += Score;
            }
        }

        if (tag == "Enemy2")
        {
            num_Clicks--;
            if (num_Clicks == 0)
            {
                GetComponent<AudioSource>().enabled = true;
                GetComponent<Movement>().enabled = false;
                animacion.SetBool("Muerte_Anim", true);
                Destroy(gameObject,2f);
                Score_UI.score += Score;
            }
        }

        if (tag == "Ally")
        {
            num_Clicks--;
            if (num_Clicks == 0)
            {
                GetComponent<AudioSource>().enabled = true;
                GetComponent<Movement>().enabled = false;
                animacion.SetBool("Muerte_Anim", true);
                Destroy(gameObject, 2f);
                Score_UI.score -= Score;
                vida_Aliado--;
            }
        }

        if (vida_Aliado <= 0)
        {
            GameOver();
        }
    }



    /* PUNTAJE DE LOS ENEMIGOS Y ALIADOS
    
    ENEMIGOS
    NECROMANCER: 35
    VALKIRYE: 20
    SOLDIER: 15
    MERCENARY: 45

    ALIADOS
    MERCHANT: 15
    MESSENGER: 25
    WARRIOR: 35
    
     */

}
