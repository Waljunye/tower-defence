using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    float Max { get; }
    float Current { get; }
    void TakeDamage(float amount);
}


