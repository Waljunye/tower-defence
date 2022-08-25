using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{

    public abstract class Towers : MonoBehaviour, ITower
    {
        public float Damage;

        public List<GameObject> EnemiesInRange { get; protected set; }

        public void TowerShoot(GameObject bullet, float shootSpeed, GameObject target)
        {

        }
        public void TowerRotate(GameObject target, bool is_trigger)
        {
            if (is_trigger)
            {
                gameObject.transform.LookAt(target.transform.position);
            }
        }


    }
}
