using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player 
{
	// The shredder class is responsible for destroying the game objects if they go too far off screen
	// Destroys the player projectiles as they keep going up.
	public class Shredder : MonoBehaviour 
	{
		void OnTriggerEnter2D(Collider2D collider)
		{
			Destroy(collider.gameObject);
		}
	}
}

