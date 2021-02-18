using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootableEnemy : MonoBehaviour
{
    public ParticleSystem enemyExplosion;
    public UnityEvent onShot, onKill;

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collided with particle");
        Destroy(gameObject);
        ParticleSystem explosion =             Instantiate(enemyExplosion, gameObject.transform.position, Quaternion.identity);

        explosion.Play();
        onShot?.Invoke();
        // Destroy(explosion.gameObject);
    }

    IEnumerator LifeTime(float time, GameObject gameObject)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}