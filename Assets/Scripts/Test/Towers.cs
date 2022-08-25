using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public abstract class Towers : MonoBehaviour, ITower 
    {
        public float Damage;
        public void TowerRotate(GameObject target, float distToAttack)
        {
            if (Vector3.Distance(gameObject.transform.position,target.transform.position) < distToAttack)
            {
                gameObject.transform.LookAt(target.transform.position);
            }
        }

        public void TowerShoot(GameObject bullet, float shootSpeed,GameObject target)
        {

        }
    }
}
