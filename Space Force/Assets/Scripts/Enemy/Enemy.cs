using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy 
{
	public class Enemy : MonoBehaviour 
	{
		[SerializeField] private float _health = 100;
		
		void OnTriggerEnter2D(Collider2D other)
		{
			var damageDealer = other.gameObject.GetComponent<DamageDealer>();
			ProcessHit(damageDealer);
		}
		private void ProcessHit(DamageDealer damageDealer)
		{
			_health -= damageDealer.Damage;

			if(_health <= 0) 
			{
				Destroy(gameObject);
			}
		}
	}
}

