using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player 
{
	public class Shredder : MonoBehaviour 
	{
		void OnTriggerEnter2D(Collider2D collider)
		{
			Destroy(collider.gameObject);
		}
	}
}

