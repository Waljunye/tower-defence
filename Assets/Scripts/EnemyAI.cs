using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent m_Agent;
    private Tower m_tower;
    private void Awake()
    {
        m_tower = FindObjectOfType<Tower>();
        
    }
    private void Start()
    {
        m_Agent.SetDestination(m_tower.transform.position);
    }
}
