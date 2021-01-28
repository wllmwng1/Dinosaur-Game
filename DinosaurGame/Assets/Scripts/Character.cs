using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Rigidbody2D rb;
    private float initHeight;
    public GameOverUI ui;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        initHeight = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && gameObject.transform.position.y <= initHeight)
        {
            rb.velocity = new Vector2(0.0f, 10.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(initHeight);
        ui.gameOver();
    }

    public void Reset()
    {
        gameObject.transform.Translate(new Vector3(0.0f,-gameObject.transform.position.y+initHeight+0.1f,0.0f));
        rb.velocity = new Vector2(0.0f, 0.0f);
    }
}
