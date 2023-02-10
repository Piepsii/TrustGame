using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private UnityEvent onAction, offAction;
    [SerializeField] private Sprite onSprite, offSprite;

    private bool isOn = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Press(bool state)
    {
        isOn = state;
        if (isOn)
        {
            onAction.Invoke();
            spriteRenderer.sprite = onSprite;
        }
        else
        {
            offAction.Invoke();
            spriteRenderer.sprite = offSprite;
        }
    }
}
