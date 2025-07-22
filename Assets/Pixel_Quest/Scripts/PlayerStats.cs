using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";
    public int coinCounter = 0;
    public int health = 3;
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
            case "Coin":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    health++;
                    Destroy(collision.gameObject); 
                    break;
                }


        }
    }
}
