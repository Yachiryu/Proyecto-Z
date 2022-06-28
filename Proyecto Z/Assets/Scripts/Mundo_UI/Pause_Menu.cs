using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Pausegame();
        }
    }
    public void Pausegame()
    {
        Time.timeScale = 0f;
    }
}
