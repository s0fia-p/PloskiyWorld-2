using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mnogoarrows : MonoBehaviour
{
    float timer = 0;
    public Vector2[] spots;
    public GameObject arrow;

	public Slider elements_slider;
	public Text elements_text;

	int elements;

    void Start()
    {
    }

    void Update()
    {
		elements = (int)(elements_slider.value);
		elements_text.text = "elements: " + elements;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            
			for (int i = 0; i < elements; i++)
            {
                arrow.transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-10, 10));
                Instantiate(arrow);
            }

            timer = 0.1f;
        }
    }
}
