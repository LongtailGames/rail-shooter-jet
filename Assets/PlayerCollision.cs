using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Player Collided with "+other.gameObject.name);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player Triggered with "+other.gameObject.name);

    }
}
