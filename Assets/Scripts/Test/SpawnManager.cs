using UnityEngine;
namespace Test
{

    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject m_EnemyObject;
        [SerializeField] private Transform m_SpawnPos;
        void Start()
        {
            Spawn();
            
            Spawn();
        }
        private void Spawn()
        {
            Instantiate(m_EnemyObject, m_SpawnPos.position, Quaternion.identity);
        }
    }
}
