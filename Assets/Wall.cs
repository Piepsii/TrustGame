using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Wall : MonoBehaviour
{
    [SerializeField] private bool killsYou;

    private TilemapCollider2D tilemapCollider;

    private void Start()
    {
        if (killsYou)
        {
            tilemapCollider = GetComponent<TilemapCollider2D>();
            tilemapCollider.isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().Respawn();
        }
    }
}
