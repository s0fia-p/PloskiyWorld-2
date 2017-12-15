using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dvizh : MonoBehaviour
{
    float x,
          y,
          delta,
          xgo,
          ygo;

    GameObject map;
    map_spots spots;

    public GameObject tochka;

    Vector2[] lol;

    void Start ()
    {
        
        map = GameObject.Find("world_map");
        spots = map.GetComponent<map_spots>();
        lol = spots.spots;

        x = Random.Range(-20, 20);
        y = Random.Range(-10, 10);
        delta = Random.Range(600, 1000);
        xgo = (x - lol[(int)transform.position[2]][0]) / delta;
        ygo = (y - lol[(int)transform.position[2]][1]) / delta;
    }

    void Update ()
    {
        
        lol[(int)this.transform.position[2]] = new Vector2
            (
                lol[(int)transform.position[2]][0] + xgo,
                lol[(int)transform.position[2]][1] + ygo
            );
        if ((lol[(int)transform.position[2]][0] > x-0.01)&&(lol[(int)transform.position[2]][0] < x+0.01))
        {

            //tochka.transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-10, 10));
            //spots.spots[(int)transform.position[2]] = tochka.transform.position;
            //Instantiate(tochka);

            //Destroy(gameObject);

            x = Random.Range(-20, 20);
            y = Random.Range(-10, 10);
            delta = Random.Range(60, 100);
            xgo = (x - lol[(int)transform.position[2]][0]) / delta;
            ygo = (y - lol[(int)transform.position[2]][1]) / delta;
        }
    }
}
