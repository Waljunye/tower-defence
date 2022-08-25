using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{


    public class BigPushka : Towers
    {
        private GameObject _target;

        
        private bool _trigger = false;
        void Start()
        {
            EnemiesInRange = new List<GameObject>();
        }

        
        private void OnTriggerEnter(Collider other)
        {
            _target = other.gameObject;
            _trigger = true;
            if (other.gameObject.CompareTag("Enemy"))
            {
                EnemiesInRange.Add(other.gameObject);
                Debug.Log("Враг в зоне поражения");
            }
        }
        private void OnTriggerExit(Collider other)
        {
            _trigger = false;
            if (other.gameObject.CompareTag("Enemy"))
            {
                EnemiesInRange.Remove(other.gameObject);
                Debug.Log("Враг вышел из зоны поражения");
            }
            
        }

        void Update()
        {
            
            TowerRotate(_target, _trigger);
            
        }
    }
}
