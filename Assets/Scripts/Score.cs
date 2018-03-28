using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int lScore;
    public int rScore;
    public Text scoreText;
    public Text winText;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = lScore + " / " + rScore;
        if (lScore >= 7)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
            winText.color = Color.green;
            winText.text = "Winner";
        }
        if (rScore >= 7)
        {
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
            winText.color = Color.red;
            winText.text = "Lose";
        }
    }
}
