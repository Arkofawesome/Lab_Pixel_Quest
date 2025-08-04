using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;

public class ZoneController : MonoBehaviour
{
    public int zone = 1;
    public GameObject zone1;
    public GameObject zone2;
    public GameObject zone3;
    public GameObject zone4;
    // Start is called before the first frame update
    void Start()    
    {
        zone1 = GameObject.Find("zone_1");
        zone2 = GameObject.Find("zone_2");
        zone3 = GameObject.Find("zone_3");
        zone4 = GameObject.Find("zone_4");
    }

    // Update is called once per frame
    void Update()
    {
        switch (zone)
        {
            case 1:
                {
                    zone1.GetComponent<SpriteRenderer>().enabled = true;
                    zone2.GetComponent<SpriteRenderer>().enabled = false;
                    zone3.GetComponent<SpriteRenderer>().enabled = false;
                    zone4.GetComponent<SpriteRenderer>().enabled = false;
                    break;
                }
            case 2:
                {
                    zone1.GetComponent<SpriteRenderer>().enabled = false;
                    zone2.GetComponent<SpriteRenderer>().enabled = true;
                    zone3.GetComponent<SpriteRenderer>().enabled = false;
                    zone4.GetComponent<SpriteRenderer>().enabled = false;
                    break;
                }
            case 3:
                {
                    zone1.GetComponent<SpriteRenderer>().enabled = false;
                    zone2.GetComponent<SpriteRenderer>().enabled = false;
                    zone3.GetComponent<SpriteRenderer>().enabled = true;
                    zone4.GetComponent<SpriteRenderer>().enabled = false;
                    break;
                }
            case 4:
                {
                    zone1.GetComponent<SpriteRenderer>().enabled = false;
                    zone2.GetComponent<SpriteRenderer>().enabled = false;
                    zone3.GetComponent<SpriteRenderer>().enabled = false;
                    zone4.GetComponent<SpriteRenderer>().enabled = true;
                    break;
                }
        }
    }
}
