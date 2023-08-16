using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject gameManager;

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("Main");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Reset Time.timeScale after the scene has been loaded
        if (Time.timeScale == 0.0f)
        {
            Time.timeScale = 1.0f;
        }
    }


}
