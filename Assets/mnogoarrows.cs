using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mnogoarrows : MonoBehaviour
{
    float timer = 0;
    public Vector2[] spots;
    public GameObject arrow;

    void Start()
    {
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            
            for (int i = 0; i < 100; i++)
            {
                arrow.transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-10, 10));
                Instantiate(arrow);
            }

            timer = 0.1f;
        }
    }
}
