using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_spots : MonoBehaviour {
    float timer = 0;
    public Vector2[] spots;
    public GameObject tochka;


    void Start () {
        spots = new Vector2[15];

            for (int i = 0; i < 15; i++)
        {
            spots[i] = new Vector2(Random.Range(-20, 20), Random.Range(-10, 10));
            tochka.transform.position = new Vector3(spots[i][0], spots[i][1], i);
            
           Instantiate(tochka);
        }
    }

    void Update()
    {

    }
}
