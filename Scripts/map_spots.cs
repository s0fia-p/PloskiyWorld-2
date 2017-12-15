using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class map_spots : MonoBehaviour {
    float timer = 0;
    public Vector2[] spots;
    public GameObject tochka;

    [DllImport("dielel")]               //ВОТ ТУТА
    private static extern int get5();   //ОБЪЯВЛЯЕМ

    void Start () {
        spots = new Vector2[15];

            for (int i = 0; i < get5()/*ВОТ ТУТА ИСПОЛЬЗУЕМ*/; i++)
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
