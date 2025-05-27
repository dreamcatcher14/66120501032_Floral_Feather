using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int SceneIndex;
    public int SceneCount;

    private void Start()
    {
        SceneCount = SceneManager.sceneCountInBuildSettings;
    }
    public void LoadNewScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        GetCurrentScene();
    }

    public void LoadNextScene()
    {
        int sceneIndex = SceneIndex + 1;
            SceneManager.LoadScene(SceneIndex + 1);
    }

    private void GetCurrentScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneIndex = scene.buildIndex;

    }
    public void Exit()
    {
        Application.Quit();
    }
}
