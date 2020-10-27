using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{


    public static ScoreController Instance;
    public int currentScore;
    public Text scoreText;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }



    void Start()
    {
        currentScore = 0;
        ChangeText();
    }

    public void HitBoard()
    {
        currentScore += 1;
        ChangeText();

    }
    
    public void UnhitBoard()
    {
        currentScore -= 1;
        ChangeText();

    }

    public void HitHole()
    {
        currentScore += 3;
        ChangeText();

    }

    void ChangeText()
    {
        scoreText.text = currentScore.ToString();
    }

    public void WinMessage()
    {
            scoreText.text = "You win!";
    }

    public void LoseMessage()
    {
            scoreText.text = "You lose!";
    }

}
