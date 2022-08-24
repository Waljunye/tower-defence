using UnityEngine;
using System;

 public enum EnemyType { one,two}
public static class StaticEnemyFactory 
{
    public static GameObject Create(EnemyType type)
    {
        GameObject enemy;

        switch (type)
        {
            case EnemyType.one:

                enemy = Resources.Load<GameObject>("Enemy/Default");
                enemy = UnityEngine.Object.Instantiate(enemy);
                return enemy;
            case EnemyType.two:
                enemy = Resources.Load<GameObject>("Enemy/DefaultSecond");
                enemy = UnityEngine.Object.Instantiate(enemy);
                return enemy;
            default:
                throw new Exception();
               
        }
    }
   
}
