using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= 3.5f)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -3.5f)
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime, Space.World);
        }
    }
}
