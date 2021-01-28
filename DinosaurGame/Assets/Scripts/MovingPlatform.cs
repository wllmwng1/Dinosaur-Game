using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float bgSpeed = -0.015f;
    public float bgInterval = -8.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOverUI.gamePaused)
        {
            gameObject.transform.Translate(new Vector2(bgSpeed * Scoreboard.speed, 0.0f));
            if (gameObject.transform.position.x < bgInterval)
            {
                gameObject.transform.Translate(new Vector2(-bgInterval, 0.0f));
            }
        }
    }
}
