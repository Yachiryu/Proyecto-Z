using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Score = 0;
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Score_UI.score += Score;
    }


}
