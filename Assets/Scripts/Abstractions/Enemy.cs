using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public abstract class Enemy : MonoBehaviour
{
    public IMove MoveImplementation;
    public IHealth HealthImplementation;
    [HideInInspector]public Vector3 destination;

    public void MoveToTarget(Vector3 position)
    {
        MoveImplementation?.MoveToTarget(position);
    }

    public void TakeDamage(float amount)
    {
        HealthImplementation?.TakeDamage(amount);
    }
    private void Update()
    {
       if(destination != default)
        {
            MoveToTarget(destination);
        }
    }
}
