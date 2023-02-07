using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // https://www.youtube.com/watch?v=mbzXIOKZurA

    public float moveSpeed = 5f;

    public LayerMask whatStopsMovement;
    public bool secondPlayer = false;

    private Transform movePoint;

    void Start()
    {
        movePoint = transform.GetChild(0);
        movePoint.parent = null;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (secondPlayer)
        {
            GetMovement("Horizontal2", "Vertical2");

        }
        else
        {
            GetMovement("Horizontal", "Vertical");
        }
    }

    private void GetMovement(string horizontal, string vertical)
    {
        if (Vector3.Distance(transform.position, movePoint.position) <= 0.5f)
        {
            if (Mathf.Abs(Input.GetAxisRaw(horizontal)) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw(horizontal), 0f, 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw(horizontal), 0f, 0f);
                }
            }
            if (Mathf.Abs(Input.GetAxisRaw(vertical)) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw(vertical), 0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw(vertical), 0f);
                }
            }
        }
    }
}
