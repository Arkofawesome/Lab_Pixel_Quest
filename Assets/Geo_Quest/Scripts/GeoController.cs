using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    string var1 = "Hello";
    int x_Value = 0;
    int y_Value = 0;
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World!");
        string var2 = "World!";
        Debug.Log(var1 +" " + var2);
        
    }// end start

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 1, 0);
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1, 0, 0);
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, -1, 0);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1, 0, 0);
        //}
        //rb.velocity = Vector2.left;

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        //Debug.Log(xInput);

    }// end update

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit!");
    }
}// end class
