using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemy 
{
	public class EnemySpawner : MonoBehaviour 
	{
		[SerializeField] private List<WaveConfig> _waveConfigs;
		[SerializeField] private bool _isLooping;
		private int _startingWave = 0;

		// Use this for initialization
		IEnumerator Start () 
		{
			// start spawning all the waves
			// keep doing this while we need to loop over the waves.
			do 
			{
				yield return StartCoroutine(SpawnAllWaves());
			}
			while(_isLooping);
		}

		private IEnumerator SpawnAllWaves()
		{
			// spawn all the waves and wait till the wave is completed
			for(var waveIndex = _startingWave; waveIndex < _waveConfigs.Count; waveIndex++)
			{
				var currentWave = _waveConfigs[waveIndex];
				yield return StartCoroutine(SpawnAllEnemies(currentWave));
			}
		}

		private IEnumerator SpawnAllEnemies(WaveConfig currentWave)
		{
			// spawn all the enemies we should spawn the first waypoint
			for(var enemyCount = 0; enemyCount < currentWave.NumberOfEnemies; enemyCount++)
			{
				var newEnemy = Instantiate(currentWave.EnemyPrefab, currentWave.Waypoints[0].transform.position, Quaternion.identity);
				newEnemy.GetComponent<EnemyPathing>().SetWaveConfig(currentWave);

				yield return new WaitForSeconds(currentWave.TimeBetweenSpawns);
			}

		}
	}
}


