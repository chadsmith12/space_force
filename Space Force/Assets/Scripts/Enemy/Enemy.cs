using Assets.Scripts.Enemy;
using Assets.Scripts.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy 
{
	public class Enemy : MonoBehaviour 
	{
		[SerializeField] private float _health = 100;
		[SerializeField] private float _shotCounter;
		[SerializeField] private float _minTimeBetweenShots = 0.2f;
		[SerializeField] private float _maxTimeBetweenShots = 3f;
		[SerializeField] private GameObject _projectilePrefab;
		[SerializeField] private GameObject _explosionPrefab;
		[SerializeField] private float _projectileSpeed = 10f;
        [SerializeField] private EnemySoundEffects _enemySoundEffects;

        void Start() 
		{
			ResetShotCounter();
		}

		void Update()
		{
			CountDownAndShoot();
		}

		void OnTriggerEnter2D(Collider2D other)
		{
			var damageDealer = other.gameObject.GetComponent<DamageDealer>();

			if(damageDealer != null)
			{
				ProcessHit(damageDealer);
			}
		}

		private void CountDownAndShoot() 
		{
			// take down the shot counter how long it was on the frame
			// if the shot counter runs out, the enemy can fire.
			_shotCounter -= Time.deltaTime;

			if(_shotCounter <= 0.0f)
			{
				Fire();
				ResetShotCounter();
			}
		}

		private void ResetShotCounter() 
		{
			_shotCounter = Random.Range(_minTimeBetweenShots, _maxTimeBetweenShots);
		}

		private void Fire()
		{
			var projectile = Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
			projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, _projectileSpeed);

            _enemySoundEffects.ShootSound.Play();
		}

		private void ProcessHit(DamageDealer damageDealer)
		{
			_health -= damageDealer.Damage;
			damageDealer.Hit();

			if(_health <= 0) 
			{
				DestroyEnemy();
			}
		}

		private void DestroyEnemy() 
		{
			StartCoroutine(Explode());
			Destroy(gameObject);
            _enemySoundEffects.DeathSound.Play();
		}

		private IEnumerator Explode()
		{
			var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(1);

			Destroy(explosion);
		}
	}
}

