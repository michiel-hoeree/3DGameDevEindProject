using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    // Methode om de score te verhogen
    public void VerhoogScore()
    {
        score += 1;
        Debug.Log("Je hebt een fiets geraakt! Score +10. Huidige score: " + score);
    }

    // Methode om de score te verlagen
    public void VerlaagScore()
    {
        score -= 1;
        Debug.Log("Je hebt een auto geraakt! Score -5. Huidige score: " + score);
    }
}
