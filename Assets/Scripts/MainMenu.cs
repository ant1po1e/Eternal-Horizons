using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class MainMenu : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject creditsPanel;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainMenu")
        {
           
        }
        Time.timeScale = 1;
        optionPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }


    void Update()
    {

    }


    public async void StartGame()
    {
        PlayButtonClickSound();
        Time.timeScale = 1;
        await Task.Delay(800);
        SceneManager.LoadScene(1);
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


    public void Credits()
    {
        PlayButtonClickSound();
        creditsPanel.SetActive(true);
    }


    public void CreditsClosed()
    {
        PlayButtonClickSound();
        creditsPanel.SetActive(false);
    }


    public void QuitGame()
    {
        PlayButtonClickSound();
        Application.Quit();
        print("Game Closed");
    }


    public void PlayButtonClickSound()
    {
        SoundManager.instance.PlayAudio(SoundManager.instance.buttonUI);
    }
}
