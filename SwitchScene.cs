using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public void SceneLevelSelect()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
        
    }

    public void SceneLevel1()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void SceneLevel2()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }

    public void SceneLevel3()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level3");
    }

    public void SceneLevel4()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level4");
    }

    public void HelpScene()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("HelpScene");
    }

    public void MainMenuScene()
    {
        Hp.Health = 5;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame() {
        Hp.Health = 5;
        Time.timeScale = 1f;
        Application.Quit();
    }

}
