using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    Vector2[] points;
    GameObject map;
    map_spots spots;

	void Start () {
        map = GameObject.Find("world_map");
        spots = map.GetComponent<map_spots>();
        points = spots.spots;
	}

    float alpha = 0;
    bool ch = true;
    float x1=0,x2=0,y1=0,y2=0,z1=0,z2=0;

    void Update () {
        points = spots.spots;

        float minimalDistance=1000000;
        Vector3 point = new Vector3();
        for (int i = 0; i <15; i++)
        {
            if (Mathf.Sqrt(Mathf.Pow(points[i][0] - transform.position[0], 2) + Mathf.Pow(points[i][1] - transform.position[1], 2)) < minimalDistance)
            {
                minimalDistance = Mathf.Sqrt(Mathf.Pow(points[i][0] - transform.position[0], 2) + Mathf.Pow(points[i][1] - transform.position[1], 2));
                point =/* point2;                point2 =*/ points[i];
                x2 = point[0];
                y2 = point[1];
                z2 = point[2];
            }
        }



        if ((transform.position[0] - point[0]) != 0) alpha = (Mathf.Atan((transform.position[1] - point[1]) / (transform.position[0] - point[0])))*180/ Mathf.PI;
        if (transform.position[0] - point[0] < 0) alpha += 180;


        if (alpha > 360) alpha = 1;
        if (!(z1==z2))
        {
            if (ch) ch = false;
            else ch = true;
        }
          if (ch)
           {
            alpha+=3;
            transform.position = new Vector2
                (
                    point[0] + (minimalDistance * 0.99f) * Mathf.Cos(Mathf.PI * alpha / 180),
                    point[1] + (minimalDistance * 0.99f) * Mathf.Sin(Mathf.PI * alpha / 180)
                );
        }
        else
        {
            alpha-=3;
            transform.position = new Vector2
                (
                    point[0] + (minimalDistance * 0.99f) * Mathf.Cos(Mathf.PI * alpha / 180),
                    point[1] + (minimalDistance * 0.99f) * Mathf.Sin(Mathf.PI * alpha / 180)
                );
        }
        if (minimalDistance < 0.4f)
            Destroy(gameObject);

        x1 = x2;
        y1 = y2;
        z1 = z2;

    }
}
