using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public abstract class Enemy : MonoBehaviour
{
    public IMove MoveImplementation;
    public IHealth HealthImplementation;

    public event Action OnMove;
    [HideInInspector]public Vector3 destination;

    public void MoveToTarget(Vector3 position)
    {
        MoveImplementation?.MoveToTarget(position);
        Debug.Log(MoveImplementation);
    }

    public void TakeDamage(float amount)
    {
        HealthImplementation?.TakeDamage(amount);
        Debug.Log(HealthImplementation);
    }
    private void Update()
    {
       if(destination != default)
        {
            MoveToTarget(destination);
        }
    }
}
