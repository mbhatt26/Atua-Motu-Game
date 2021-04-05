using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public int _id;

    void Start()
    {
        if (GameState.Gems[_id])
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the other collider is the player
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            GameState.Gems[_id] = true;
        }
    }
}
