using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text text;
    public static int score = 0;
    public int scoreFactor = 10;
    public static int highScore = 0;
    public static float speed = 1.0f;
    private float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOverUI.gamePaused)
        {
            text.text = "Score: " + score/scoreFactor + "\nHigh Score: " + highScore/scoreFactor;
            score += 1;
            counter += Time.deltaTime;
            if (counter > 5)
            {
                Debug.Log(speed);
                speed = Mathf.Min(speed + 0.1f, 2.0f);
                counter = 0;
            }
            
        }
    }
}
