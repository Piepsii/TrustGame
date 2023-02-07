using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    [SerializeField] private UnityEvent onAction, offAction;

    private bool isOn = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Press()
    {
        isOn = !isOn;
        if (isOn)
        {
            onAction.Invoke();
            animator.SetTrigger("on");
        }
        else
        {
            offAction.Invoke();
            animator.SetTrigger("off");
        }
    }
}
