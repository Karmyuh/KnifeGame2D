using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] GameObject _pausePanel;

    public void PauseButtonOnClick()
    {
        Time.timeScale = 0;
        _pausePanel.SetActive(true);
    }


    public void ResumeButtonOnClick()
    {
        Time.timeScale = 1;
        _pausePanel.SetActive(false);
    }


    public void MainMenuButtonOnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void QuitButtonOnClick()
    {
        Application.Quit();
    }

}
