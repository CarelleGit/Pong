using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour
{
    public BallScript ball;
    public Player player;
    float speed;
    // Use this for initialization
    void Start()
    {
        speed = player.movementSpeed / 1.6f;
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.y <= transform.position.y && transform.position.y >= -3.5f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        }
        if (ball.transform.position.y >= transform.position.y && transform.position.y <= 3.5f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
        }
    }
}
