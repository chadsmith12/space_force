using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
	[SerializeField] private GameObject _enemyPrefab;
	[SerializeField] private GameObject _pathPrefab;
	[SerializeField] private float _timeBetweenSpawns = 0.5f;
	[SerializeField] private float _spawnRandomFactor = 0.3f;
	[SerializeField] private int _numberOfEnemies = 5;
	[SerializeField] private float _moveSpeed = 2f;

	// Gets the prefab for this enemy.
	public GameObject EnemyPrefab
	{
		get 
		{
			return _enemyPrefab;
		}
	}
	// Gets the prefab for this path.
	public List<Transform> Waypoints
	{
		get 
		{
			var waveWayPoints = _pathPrefab.transform.OfType<Transform>().Select(child => child);
			return waveWayPoints.ToList();
		}
	}
	// Gets the time between enemy spawns.
	public float TimeBetweenSpawns 
	{
		get 
		{
			return _timeBetweenSpawns;
		}
	}

	// Gets the random factor of the spawning
	public float SpawnRandomFactor 
	{
		get
		{
			return _spawnRandomFactor;
		}
	}

	// Gets the number of enemies this wave will have in it
	public int NumberOfEnemies
	{
		get
		{
			return _numberOfEnemies;
		}
	}

	// Gets the movement speed of the wave.
	public float MoveSpeed 
	{
		get
		{
			return _moveSpeed;
		}
	}
}
