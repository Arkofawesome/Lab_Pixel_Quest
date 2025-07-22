using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.tag);
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;

                }


        }
    }
}
