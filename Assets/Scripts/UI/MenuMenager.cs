using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }


}
