using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void ChangeSceneTo (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitNow()
    {
        Application.Quit();
    }
}
