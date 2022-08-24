using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_EnemyObject;
    [SerializeField] private Transform m_SpawnPos;
    void Start()
    {
        Spawn();
    }
    private void Spawn()
    {
        var enemy1 = StaticEnemyFactory.Create(EnemyType.one).transform.position = m_SpawnPos.position;
        var enemy6 = StaticEnemyFactory.Create(EnemyType.one).transform.position = m_SpawnPos.position;
        var enemy5 = StaticEnemyFactory.Create(EnemyType.one).transform.position = m_SpawnPos.position;
        var enemy2 = StaticEnemyFactory.Create(EnemyType.two).transform.position = m_SpawnPos.position;
        var enemy3 = StaticEnemyFactory.Create(EnemyType.two).transform.position = m_SpawnPos.position;
        var enemy4 = StaticEnemyFactory.Create(EnemyType.two).transform.position = m_SpawnPos.position;
        //Instantiate(m_EnemyObject,m_SpawnPos.position,Quaternion.identity);
    }
}
