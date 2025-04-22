using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject finalGame;
    public GameObject startGame;
    public static GameControll instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void ShowFinalGame()
    {
        finalGame.SetActive(true);
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        startGame.SetActive(false);
        Time.timeScale = 1;
    }
}
