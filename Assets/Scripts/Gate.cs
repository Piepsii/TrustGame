using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private bool multiway;
    [SerializeField] private int numberOfLevers = 1;
    [SerializeField] private float speed;
    [SerializeField] private Transform target;

    private bool moveToTarget = false;
    private Vector3 start;

    void Start()
    {
        start = transform.position;
    }

    void Update()
    {
        if (moveToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, start, speed * Time.deltaTime);
        }
    }

    public void Switch()
    {
        moveToTarget = !moveToTarget;

    }

    public void On()
    {
        numberOfLevers--;
        if (numberOfLevers == 0)
        {
            moveToTarget = true;
        }
    }

    public void Off()
    {
        numberOfLevers++;
        moveToTarget = false;
    }
}
