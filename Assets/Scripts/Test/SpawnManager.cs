using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_EnemyObject;
    [SerializeField] private Transform m_SpawnPos;
    private Vector3 globaldestination;
    private void Start()
    {
        globaldestination = GameObject.FindGameObjectWithTag("Finish").transform.position;
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        Enemy enemy1 = StaticEnemyFactory.Create(new EnemyHealth(100f), 3f, EnemyType.First, m_SpawnPos);
        enemy1.destination = globaldestination;
        yield return new WaitForSeconds(5);
        Enemy enemy2 = StaticEnemyFactory.Create(new EnemyHealth(100f), 2f, EnemyType.Second, m_SpawnPos);
        enemy2.destination = globaldestination;
    } 
}
