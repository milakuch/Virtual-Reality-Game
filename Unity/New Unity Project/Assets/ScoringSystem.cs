using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public static int theScore;
    public Boolean done;
    public AudioSource Effect;

    void Start()
    {
        theScore = 0;
        done = false;
    }

    // Update is called once per frame
    void Update()  {       }

    public void ScoreUp() {
        if (done == false)
        {
            theScore += 1;
            scoreText.GetComponent<Text>().text = "Score: " + theScore;
            Effect.Play();
            done = true;
        }
    }

}
