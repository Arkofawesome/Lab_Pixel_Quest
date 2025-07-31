using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
    public static GameData Instance { get; private set; }

    void Awake()
    {
        // If another instance already exists, destroy this one
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Assign the instance and make it persist between scenes
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Example method
    public void DoSomething()
    {
        Debug.Log("Singleton is working!");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("NewYorkCity");
        }
    }
}