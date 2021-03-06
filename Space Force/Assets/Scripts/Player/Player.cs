﻿using Assets.Scripts.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player 
{
	public class Player : MonoBehaviour 
	{
		[Header("Player")]
		[SerializeField] private float _moveSpeed = 10f;
		[SerializeField] private float _padding = 1f;
		[SerializeField] private int _health = 200;

		[Header("Projectile")]
		[SerializeField] private GameObject _laserPrefab;
		[SerializeField] private float _projectileSpeed = 10f;
		[SerializeField] private float _projectileFiringPeriod = 0.5f;

        [Header("Sound")]
        [SerializeField] private PlayerSoundEffects _playerSoundEffects;

        private float _xMin;
		private float _xMax;
		private float _yMin;
		private float _yMax;
		private Coroutine _firingCoroutine;
		private float _nextFire = 0.0f;

        /// <summary>
        /// Gets the current health of the player.
        /// </summary>
        public int CurrentHealth
        {
            get
            {
                return _health;
            }
        }

        // Use this for initialization
        void Start () 
		{
			SetBoundaries();
		}
		
		// Update is called once per frame
		void Update () 
		{
			Move();
			Fire();
		}

		void OnTriggerEnter2D(Collider2D other)
		{
			var damageDealer = other.gameObject.GetComponent<DamageDealer>();
			ProcessHit(damageDealer);
		}

		private void Move()
		{
			var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
			var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;

			var newXPosition = Mathf.Clamp(transform.position.x + deltaX, _xMin, _xMax);
			var newYPosition = Mathf.Clamp(transform.position.y + deltaY, _yMin, _yMax);

			transform.position = new Vector2(newXPosition, newYPosition);
		}

		private void SetBoundaries()
		{
			var gameCamera = Camera.main;

			_xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + _padding;
			_xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - _padding;
			_yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + _padding;
			_yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - _padding;
		}

		private void Fire()
		{
			// fire the projectiles continously when holding down fire.
			// when you let up the button stop the continously firing.
			if(Input.GetButtonDown("Fire1") && Time.time > _nextFire)
			{
				_nextFire = Time.time + _projectileFiringPeriod;
				_firingCoroutine = StartCoroutine(FireContinuously());
			}
			if(Input.GetButtonUp("Fire1"))
			{
				StopCoroutine(_firingCoroutine);
			}
		}

		private IEnumerator FireContinuously()
		{
			while(true)
			{
				var projectile = Instantiate(_laserPrefab, transform.position, Quaternion.identity);
				projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, _projectileSpeed);

                _playerSoundEffects.ShootSound.Play();
				yield return new WaitForSeconds(_projectileFiringPeriod);
			}

		}

		private void ProcessHit(DamageDealer damageDealer)
		{
			_health -= damageDealer.Damage;
			damageDealer.Hit();

			if(_health <= 0) 
			{
                DestroyPlayer();
			}
		}

        private void DestroyPlayer()
        {
            Destroy(gameObject);
            _playerSoundEffects.DeathSound.Play();
            LevelManagment.LoadGameOver();
        }
	}
}
