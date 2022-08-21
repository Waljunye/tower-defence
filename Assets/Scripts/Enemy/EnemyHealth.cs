using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : IHealth
{
    public float Max { get; private set; }

    public float Current { get; private set; }
    private event Action _onZeroHp;

    public void TakeDamage(float damageValue)
    {
        Current -= damageValue;
        if(Current <= 0)
        {
            _onZeroHp?.Invoke();
        }
    }
    public EnemyHealth(float maxHp, Action OnZeroHp = null)
    {
        Max = maxHp;
        Current = Max;
        _onZeroHp += OnZeroHp;
    }

}
