using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject beanbags;
    public Canvas pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WinGame();
        LoseGame();
        
    }

    public void WinGame()
    {
        if(ScoreController.Instance.currentScore == 21)
        {
            ScoreController.Instance.WinMessage();

        }
    }
    public void LoseGame()
    {
        if(ScoreController.Instance.currentScore > 21)
        {
            ScoreController.Instance.LoseMessage();
        }
    }

    public void pauseGame(bool pause)
    {
        pauseCanvas.gameObject.SetActive(pause);  
        Time.timeScale = (pause) ? 0 : 1f;
    }

    public void Replay()
    {
        ScoreController.Instance.currentScore = 0;
        Time.timeScale = 1f;
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}
