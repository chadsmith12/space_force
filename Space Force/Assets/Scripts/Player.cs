using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player 
{
	public class Player : MonoBehaviour 
	{
		[SerializeField]
		private float _moveSpeed = 10f;
		[SerializeField]
		private float _padding = 1f;
		[SerializeField]
		private GameObject _laserPrefab;
		[SerializeField]
		private float _projectileSpeed = 10f;


        private float _xMin;
		private float _xMax;
		private float _yMin;
		private float _yMax;


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
			if(Input.GetButtonDown("Fire1"))
			{
				var projectile = Instantiate(_laserPrefab, transform.position, Quaternion.identity);
				projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, _projectileSpeed);
			}
		}
	}
}
