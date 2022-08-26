using UnityEngine;
using System;

 public enum EnemyType { First, Second }
public static class StaticEnemyFactory 
{
    public static Enemy Create(IHealth healthImplementation, float speed, EnemyType type, Transform spawnPosition)
    {
        Enemy enemy;

        switch (type)
        {
            case EnemyType.First:

                enemy = Resources.Load<Enemy>("Enemy/Enemy_01");
                break;
            case EnemyType.Second:
                enemy = Resources.Load<Enemy>("Enemy/DefaultSecond");
                break;
            default:
                throw new Exception();
               
        }
        enemy = UnityEngine.Object.Instantiate(enemy, spawnPosition.position, spawnPosition.rotation);
        enemy.HealthImplementation = healthImplementation;
        enemy.MoveImplementation = new EnemyNavMeshMove(enemy.gameObject.GetOrAddComponent<UnityEngine.AI.NavMeshAgent>(), speed);
        return enemy;
    }
}
