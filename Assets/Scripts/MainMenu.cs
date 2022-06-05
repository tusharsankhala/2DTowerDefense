using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startSceneName;
    
    public void LoadStartScene()
    {
        SceneManager.LoadScene(startSceneName);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();    
    }
}