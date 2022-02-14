using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject GameOverPanel;

    public void Back()
    {
        if(Time.timeScale == 0.0f)
        {
            SettingsPanel.SetActive(false);
            Time.timeScale = 1.0f;
        }
        else
        {
            SettingsPanel.SetActive(false);
            GameOverPanel.SetActive(true);
        }

    }
}
