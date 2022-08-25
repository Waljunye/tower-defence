using UnityEngine;
using System.Collections.Generic;
namespace Test
{
    public interface ITower
    {
        public void TowerShoot(GameObject bullet, float shootSpeed, GameObject target);

        public void TowerRotate(GameObject target, bool is_trigger);

        public List<GameObject> EnemiesInRange { get; }

    }
}
