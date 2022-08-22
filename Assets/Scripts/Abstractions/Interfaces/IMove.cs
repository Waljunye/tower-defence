using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    float Speed { get; }
    void MoveToTarget(Vector3 position);
}
