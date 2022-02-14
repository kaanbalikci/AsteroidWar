using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver GO;

    [SerializeField] private GameObject gameoverpanel;

    private void Awake()
    {
        GO = this;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartGame");
    }

    public void QuitGame()
    {
        Application.Quit();
          
    }

    public void GameOverUI()
    {
        
        gameoverpanel.SetActive(true);
       
    }

    public void playagain()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameoverpanel.SetActive(false);
    }



}
