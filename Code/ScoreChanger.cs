using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChanger : MonoBehaviour
{
    public Text score;
    public static int points;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        score.text = "Score: " + points;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        score.text = "Score: " + points;
        if (timer >= 0.25f) {
            points += 1;
            score.text = "Score: " + points;
            timer = 0;
        }
    }
}
