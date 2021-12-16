using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Congrats;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if(Collect.score == 11)
        {
            Congratulations();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Propeller.rotateAmount = 20;
        CoinRotate.rotateCoin = 1;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
        Propeller.rotateAmount = 0;
        CoinRotate.rotateCoin = 0;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUITTED");
    }

    public void Congratulations()
    {
        Congrats.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
        Propeller.rotateAmount = 0;
        CoinRotate.rotateCoin = 0;
    }

}