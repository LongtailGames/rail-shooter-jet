using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableEnemy : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collided with particle");
    }
}
