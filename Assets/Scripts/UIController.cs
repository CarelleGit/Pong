using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    Text restart;
    public RightPaddle rightPaddle;
    public Player player;
    public BallScript ball;

    Score score;

    int lScore;
    int rScore;

    public GameObject canvas;
    public GameObject tallyPanel;


    // Use this for initialization
    void Start()
    {
        lScore = score.lScore;
        rScore = score.rScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ball.transform.position = new Vector2(0, 0);
            player.transform.position = new Vector2(-7.78f, 0);
            rightPaddle.transform.position = new Vector2(7.78f, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            canvas.SetActive(true);
                Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            canvas.SetActive(false);
        }
        if (canvas.activeInHierarchy == false)
        {
            if (lScore < 7 || rScore < 7)
            {
                if (Input.GetKey(KeyCode.T))
                {
                    tallyPanel.SetActive(true);
                    Time.timeScale = 0.5f;
                }
                if (!Input.GetKey(KeyCode.T))
                {
                    tallyPanel.SetActive(false);
                    Time.timeScale = 1;
                }
            }
        }
    }
}
