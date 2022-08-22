using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent m_Agent;
    private GameObject m_tower;
    private void Awake()
    {
        m_tower = GameObject.FindGameObjectWithTag("Finish");
        
    }
    private void Start()
    {
        m_Agent.SetDestination(m_tower.transform.position);
    }
}
