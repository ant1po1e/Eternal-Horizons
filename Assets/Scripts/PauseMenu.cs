using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionPanel;
    public GameObject GUI;
    bool isPaused;

    void Awake()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        optionPanel.SetActive(false);
        isPaused = false;
    }

    void Update()
    {
        Pause();
    }

    public void Pause()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            PlayButtonClickSound();
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            GUI.SetActive(false);
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            PlayButtonClickSound();
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            GUI.SetActive(true);
            isPaused = false;
        }
    }

    public void Options()
    {
        PlayButtonClickSound();
        optionPanel.SetActive(true);
    }


    public void OptionsClosed()
    {
        PlayButtonClickSound();
        optionPanel.SetActive(false);
    }

    public void GoToMainMenu()
    {
        PlayButtonClickSound();
        SceneManager.LoadScene(0);
    }

    public void PlayButtonClickSound()
    {
        SoundManager.instance.PlayAudio(SoundManager.instance.buttonUI);
    }
}
