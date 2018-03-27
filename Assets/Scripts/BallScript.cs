using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rb2;
    public float speed = 5;

    // Use this for initialization
    void Start()
    {
        rb2.AddForce(new Vector2(Random.Range(-speed * 2, speed * 2), Random.Range(-speed, speed)).normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody.tag == "Goal")
        {
            transform.position = new Vector2(0, 0);
            //transform.position = new Vector2(0, 0);
        }
            rb2.velocity *= 1.005f;
    }
}
