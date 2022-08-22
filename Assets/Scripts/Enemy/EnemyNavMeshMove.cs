using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMeshMove : IMove
{
    public float Speed { get; private set; }
    private NavMeshAgent _navMeshAgent;
    public void MoveToTarget(Vector3 position)
    {
        _navMeshAgent.SetDestination(position);
    }
    public EnemyNavMeshMove(NavMeshAgent navMeshAgent, float speed)
    {
        _navMeshAgent = navMeshAgent;
        Speed = speed;
        _navMeshAgent.speed = Speed;
    }
}
