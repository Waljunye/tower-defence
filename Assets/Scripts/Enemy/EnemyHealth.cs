using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : IHealth
{
    public float MaxHealth { get; private set; }

    public float CurrentHealth { get; private set; }
    private event Action _onZeroHp;

    public void TakeDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        if(CurrentHealth <= 0)
        {
            _onZeroHp?.Invoke();
        }
    }
    public EnemyHealth(float maxHp, Action OnZeroHp = null)
    {
        MaxHealth = maxHp;
        CurrentHealth = MaxHealth;
        _onZeroHp += OnZeroHp;
    }

}
