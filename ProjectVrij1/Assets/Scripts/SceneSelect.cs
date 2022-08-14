using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public void loadMainScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void loadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
