using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_EnemyObject;
    [SerializeField] private Transform m_SpawnPos;
    private Enemy enemy;
    void Start()
    {
        Spawn();
    }
    private void Spawn()
    {
        enemy = Instantiate(m_EnemyObject, m_SpawnPos.position, m_SpawnPos.rotation).GetComponent<Enemy>();
        enemy.Speed = 3f;
        enemy.destination = GameObject.FindGameObjectWithTag("Finish").transform.position;
    }
}
