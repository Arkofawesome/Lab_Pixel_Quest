using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPCWalking : MonoBehaviour
{
    public float speed = 2f;
    public Transform teleportTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
     
    }
}
