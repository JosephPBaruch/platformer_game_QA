using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
        Time.timeScale = 1.0f;
    }

    public void exit()
    {
        Application.Quit();
    }
}
