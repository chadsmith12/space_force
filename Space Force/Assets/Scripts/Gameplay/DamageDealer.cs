﻿using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class DamageDealer : MonoBehaviour
    {
        [SerializeField] private int _damage = 100;

        // Gets the amount of damage this does.
        public int Damage
        {
            get
            {
                return _damage;
            }
        }

        public void Hit()
        {
            Destroy(gameObject);
        }
    }
}
