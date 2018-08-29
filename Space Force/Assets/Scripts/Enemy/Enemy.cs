using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{
	[SerializeField] private float _health = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		var damageDealer = other.gameObject.GetComponent<DamageDealer>();
		_health -= damageDealer.Damage;
	}
}
