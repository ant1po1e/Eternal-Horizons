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
        Time.timeScale = 1;
        await Task.Delay(800);
        SceneManager.LoadScene(1);
    }


    public void Options()
    {
        optionPanel.SetActive(true);
    }


    public void OptionsClosed()
    {
        optionPanel.SetActive(false);
    }


    public void Credits()
    {
        creditsPanel.SetActive(true);
    }


    public void CreditsClosed()
    {
        creditsPanel.SetActive(false);
    }


    public void QuitGame()
    {
        Application.Quit();
        print("Game Closed");
    }
}
