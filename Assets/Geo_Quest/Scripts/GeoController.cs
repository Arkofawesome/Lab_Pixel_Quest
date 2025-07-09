using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    string var1 = "Hello";
    int value = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string var2 = "World!";
        Debug.Log(var1 +" " + var2);
        
    }// end start

    // Update is called once per frame
    void Update()
    {
        Debug.Log(value);
        value++;
        
    }// end update
}// end class
