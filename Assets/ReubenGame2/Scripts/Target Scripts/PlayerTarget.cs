using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTarget : MonoBehaviour
{
    private float damageAmmount = 10f;    
    public float health = 100f;

    
    void Awake()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    void OnEnable()
    {
        FPSGameEvents.OnTargetHit += OnTargetHit;
    }
    void OnDisable()
    {
        FPSGameEvents.OnTargetHit -= OnTargetHit;
    }

    void OnTargetHit(Target target)
    {
        TakeDamage(damageAmmount);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log(health);
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Dead");
    }
}
