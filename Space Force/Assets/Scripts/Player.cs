using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player 
{
	public class Player : MonoBehaviour 
	{
		[SerializeField]
		private float _moveSpeed = 10f;

		// Use this for initialization
		void Start () 
		{
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			Move();
		}

		private void Move()
		{
			var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
			var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;

			var newXPosition = transform.position.x + deltaX;
			var newYPosition = transform.position.y + deltaY;

			transform.position = new Vector2(newXPosition, newYPosition);
		}
	}
}
