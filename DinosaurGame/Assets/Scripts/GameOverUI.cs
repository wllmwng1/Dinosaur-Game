using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text text;
    public static bool gamePaused;
    public Character mc;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
        gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gamePaused)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Respawn");
            foreach (GameObject respawn in objects)
            {
                Destroy(respawn);
            }
            mc.Reset();
            Scoreboard.score = 0;
            Scoreboard.speed = 1.0f;
            text.enabled = false;
            gamePaused = false;
            Time.timeScale = 1f;
        }
    }

    public void gameOver()
    {
        text.enabled = true;
        gamePaused = true;
        Time.timeScale = 0f;
        Scoreboard.highScore = Mathf.Max(Scoreboard.score, Scoreboard.highScore);
    }
}
