using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string single;
    public string multi;



    public void loadSingle()
    {
      SceneManager.LoadScene(single);
    }

    public void loadMulti()
    {
       SceneManager.LoadScene(multi);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
