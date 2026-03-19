using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public class car : MonoBehaviour
{
    public float speed;
    public float baseSpeed;
    public List<GameObject> path;
    private int pathIdx;
    public float frame;
    public float aero;
    public float tires;
    public float engineFactor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5f;
        engineFactor = 1f;
        pathIdx = 0;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if (transform.position == path[pathIdx].transform.position)
        {
            if (pathIdx == path.Count - 1)
            {
                pathIdx = 0;
            } else
            {
                pathIdx++;
            }
        }
        speed = (baseSpeed+frame+aero+tires)*engineFactor;
        transform.position = Vector2.MoveTowards(transform.position, path[pathIdx].transform.position, speed * Time.deltaTime);
    }
}
