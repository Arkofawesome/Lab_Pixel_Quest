using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{

    public string NextScene;


    public void LoadLevel()
    {
        SceneManager.LoadScene(NextScene);


    }

    public void QuitGame()
    {
        Application.Quit();



    }
}