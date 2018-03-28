using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D rb2;
    public float speed = 5;

    public Text lScoreText;
    public Text rScoreText;

    public Score score;

    public float timer;

    public float timeLimit;

    // Use this for initialization
    void Start()
    {
        rb2.AddForce(new Vector2(Random.Range(-speed * 2, speed * 2), Random.Range(-speed, speed)).normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (score != null)
        {

            if (rScoreText.IsActive())
            {
                timer += Time.deltaTime;
                rScoreText.text = score.rScore.ToString();

                if (timer >= timeLimit)
                {
                    rScoreText.gameObject.SetActive(false);
                    timer = 0;

                }
            }

            if (lScoreText.IsActive())
            {
                timer += Time.deltaTime;
                lScoreText.text = score.lScore.ToString();

                if (timer >= timeLimit)
                {
                    lScoreText.gameObject.SetActive(false);
                    timer = 0;

                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
             if (collision.rigidbody.tag == "Goal")
        {
            transform.position = new Vector2(0, 0);
            //transform.position = new Vector2(0, 0);
        }
        if(collision.rigidbody.tag == "Lgoal")
        {
                      score.rScore += 1;
            rScoreText.gameObject.SetActive(true);
        }
        if (collision.rigidbody.tag == "Goal")
        {
            score.lScore += 1;
            lScoreText.gameObject.SetActive(true);
        }
        rb2.velocity *= 1.005f;
    }
}
