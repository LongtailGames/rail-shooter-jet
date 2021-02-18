using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    public UnityEvent onEnemyCollision;
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Player Collided with "+other.gameObject.name);
        if (!other.gameObject.CompareTag("Enemy")) return;
        onEnemyCollision?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player Triggered with "+other.gameObject.name);
        if (!other.CompareTag("Enemy")) return;
        onEnemyCollision?.Invoke();

    }
}
