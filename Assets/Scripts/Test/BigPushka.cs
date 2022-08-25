using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class BigPushka : Towers
    {
        [SerializeField] private GameObject _target;
        
        private float _dis = 10; //Test 
        void Start()
        { 
        }


        void Update()
        {
            TowerRotate(_target, _dis);
        }
    }
}
