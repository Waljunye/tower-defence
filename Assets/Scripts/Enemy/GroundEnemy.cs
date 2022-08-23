using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundEnemy : Enemy
{
    public event Action OnDeath;
    private Animator _animator;
    private void Start()
    {
        NavMeshAgent navMeshAgent;
        if (gameObject.TryGetComponent<NavMeshAgent>(out navMeshAgent))
        {
            _moveImplementation = new EnemyNavMeshMove(navMeshAgent, Speed);
        }
        else
        {
            throw new Exception("Can't resolve NavMeshAgent");
        }
        if (gameObject.TryGetComponent<Animator>(out _animator))
        {
            OnDeath += () => _animator.SetTrigger("onDead");
        }
        else
        {
            throw new Exception("Can't resolve Animator");
        }
        _healthImplementation = new EnemyHealth(MaxHealth, OnDeath);
        
    }
}
