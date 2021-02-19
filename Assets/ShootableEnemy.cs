using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootableEnemy : MonoBehaviour
{
    public ParticleSystem enemyExplosion, shotExplosion;

    public UnityEvent onShot, onKill;
    [SerializeField] private int hitPoints;
    private List<ParticleCollisionEvent> collisionEvents;

    private void Start()
    {
        onKill.AddListener(DeathExplosion);
        onShot.AddListener(DamageBy10);
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collided with particle");
        Instantiate(shotExplosion, transform.position, Quaternion.identity);
        onShot?.Invoke();
    }

    void DamageBy10()
    {
        ReduceHitPoints(10);
    }

    void ReduceHitPoints(int damage)
    {
        hitPoints -= damage;
        if (hitPoints < 0)
        {
            onKill?.Invoke();
        }
    }

    private void DeathExplosion()
    {
        ParticleSystem explosion = Instantiate(enemyExplosion, gameObject.transform.position, Quaternion.identity);

        explosion.Play();
        Destroy(gameObject);
    }

    IEnumerator LifeTime(float time, GameObject gameObject)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}