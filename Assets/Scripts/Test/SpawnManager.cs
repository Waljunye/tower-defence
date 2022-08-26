using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_EnemyObject;
    [SerializeField] private Transform m_SpawnPos;
    private Enemy enemy;
    private 
    void Start()
    {
        Spawn();
    }
    private void Spawn()
    {
        enemy = StaticEnemyFactory.Create(new EnemyHealth(100f), 2f, EnemyType.First, m_SpawnPos);
        enemy.destination = GameObject.FindGameObjectWithTag("Finish").transform.position;
        Debug.Log(enemy.destination);
    }
}
