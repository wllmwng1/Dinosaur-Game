using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifetime > 0)
        {
            lifetime -= Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    
}
