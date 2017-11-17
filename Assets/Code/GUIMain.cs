using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIMain : MonoBehaviour {
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
