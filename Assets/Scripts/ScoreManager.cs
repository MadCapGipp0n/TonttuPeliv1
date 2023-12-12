using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highScoretext;

    public static int score;
    

     
    

     void Start()
    {
         scoreText.text = "Score: " + Mathf.Round(score);
        
    }

     // Update is called once per frame
    // public void AddPoint()
    // {
    //      score += 1;
    //      scoreText.text = score.ToString() + " POINTS";
    // }
}
