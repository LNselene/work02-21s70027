using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanceUI : MonoBehaviour
{
    GameObject circle;
    GameObject goal;
    GameObject distance;

    void Start()
    {
        this.circle = GameObject.Find("Circle");
        this.goal = GameObject.Find("goal");
        this.distance = GameObject.Find("distance");
    }

    void Update()
    {
        float length = this.goal.transform.position.x - this.circle.transform.position.x;
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "ÉSÅ[ÉãÇ‹Ç≈" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over";
        }
    }
}
