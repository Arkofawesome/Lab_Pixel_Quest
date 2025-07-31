using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPoints : MonoBehaviour
{
    public float waitTime = 1;
    private float currentTime = 1;
    public float speed = 5;
    public Transform[] patrolPoints;
    public int patrolIndex = 0;
    public Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = patrolPoints[patrolIndex].position;
        currentTime = waitTime;

        //render = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[patrolIndex].position,
            speed * Time.deltaTime);

        if (transform.position == patrolPoints[patrolIndex].position)
        {
            if (currentTime < 0)
            {
                patrolIndex++;
                if (patrolIndex >= patrolPoints.Length)
                {
                    patrolIndex = 0;
                }
                if (patrolIndex == 0 )
                {
                    //render.enabled = false;
                    Vector3 direction = patrolPoints[1].position - patrolPoints[0].position;
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.Euler(0, 0, angle);
                    patrolIndex = 1;
                    transform.position = patrolPoints[0].position;
                }
                else if (patrolIndex == 2)
                {
                    Vector3 direction = patrolPoints[2].position - patrolPoints[1].position;
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.Euler(0, 0, angle);

                }
                else if (patrolIndex == 3)
                {
                    Vector3 direction = patrolPoints[3].position - patrolPoints[2].position;
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.Euler(0, 0, angle);
                }
                currentTime = waitTime;
            }
            else
            {
                currentTime -= Time.deltaTime;
            }

        }
    }
}
