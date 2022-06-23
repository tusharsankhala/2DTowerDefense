using System.Collections;
using System.Collections.Generic;
using TowerDefense.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startSceneName;
    
    public void LoadStartScene()
    {
        AudioManager.instance.PlaySFX(3);
        SceneManager.LoadScene(startSceneName);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        AudioManager.instance.PlaySFX(3);
        Application.Quit();    
    }
}