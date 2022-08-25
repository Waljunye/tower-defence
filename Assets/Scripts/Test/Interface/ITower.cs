using UnityEngine;

namespace Tests
{
    public interface ITower
    {
        public void TowerShoot(GameObject bullet, float shootSpeed, GameObject target);
       
        public void TowerRotate(GameObject target, float distToAttack);
        
    }
}