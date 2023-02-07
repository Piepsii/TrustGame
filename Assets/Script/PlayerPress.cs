using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPress : MonoBehaviour
{
    [SerializeField] private KeyCode pressKey;

    private Lever lever;
    private bool isInRange = false;

    private void Update()
    {
        if (Input.GetKeyDown(pressKey))
        {
            if(isInRange)
            {
                lever.Press();
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Lever")){
            lever = collider.GetComponent<Lever>();
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Lever"))
        {
            isInRange = false;
        }
    }
}
