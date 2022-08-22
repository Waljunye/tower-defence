using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent m_Agent;
    
    
    void Update()
    {
        var m_Tower = FindObjectOfType<Tower>();
        m_Agent.SetDestination(m_Tower.transform.position);
    }
}
