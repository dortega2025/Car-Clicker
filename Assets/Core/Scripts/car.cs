using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.UIElements;

public class car : MonoBehaviour
{
    public float speed;
    public float baseSpeed;
    public float frame;
    public float aero;
    public float tires;
    public float engineFactor;
    public List<GameObject> path;
    private int pathIdx;
    private GameObject manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baseSpeed = 15f;
        engineFactor = 1f;
        pathIdx = 0;
        manager = GameObject.FindGameObjectWithTag("manager");
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
        Vector3 dir = path[pathIdx].transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        angle = Mathf.Repeat(angle, 360);
        angle = angle - transform.rotation.z;
        transform.eulerAngles = new Vector3(0, 0, angle);
        speed = (baseSpeed + frame + aero + tires) * engineFactor;
        transform.position = Vector2.MoveTowards(transform.position, path[pathIdx].transform.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        manager.GetComponent<systemManager>().increasePoints();
    }
}
