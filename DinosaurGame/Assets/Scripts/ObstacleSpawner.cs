using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private float interval;
    public GameObject item;
    private Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(1.0f, 3.0f);
        rot = item.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        else
        {
            Vector2 loc = gameObject.transform.position + new Vector3(0.0f, Random.Range(0.0f, 3.0f), gameObject.transform.position.z);
            GameObject created = Instantiate(item, loc, rot);
            var script = created.GetComponent<Obstacle>();
            script.speed = -5*Scoreboard.speed;
            script.lifetime = 10;
            interval = Random.Range(1, 3);
        }
    }
}
