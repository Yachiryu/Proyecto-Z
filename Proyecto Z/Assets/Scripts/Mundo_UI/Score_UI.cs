using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour
{
    public static int score = 0;
    public string scoreText = "Score";

    public Text textscore;
    public static Score_UI gamecontroller;

    void Awake()
    {
        gamecontroller = this;
    }

    void Update()
    {
        if(textscore != null)
        {
            textscore.text = scoreText + score.ToString();
        }
    }




}
