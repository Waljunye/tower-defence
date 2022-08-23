using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public abstract class Enemy : MonoBehaviour, IMove, IHealth
{
    protected IMove _moveImplementation;
    protected IHealth _healthImplementation;

    public float Speed { get; set; }
    public float MaxHealth { get; private set; }
    public float CurrentHealth { get; private set; }
    public event Action OnMove;
    public Vector3 destination;

    public void MoveToTarget(Vector3 position)
    {
        _moveImplementation?.MoveToTarget(position);
    }

    public void TakeDamage(float amount)
    {
        _healthImplementation?.TakeDamage(amount);
    }
    private void Update()
    {
       if(destination != default)
        {
            MoveToTarget(destination);
        }
    }
}
