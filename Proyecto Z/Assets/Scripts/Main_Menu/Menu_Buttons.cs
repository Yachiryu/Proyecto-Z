using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego_Principal");
    }

    public void Salir()
    {
        Debug.Log("Saliendo.....");
        Application.Quit();
    }
}
