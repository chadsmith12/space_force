using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Assets.Scripts.Enemy
{
	public class EnemyPathing : MonoBehaviour 
	{
		[SerializeField] private float _moveSpeed = 2f;
		[SerializeField] WaveConfig _waveConfig;

		private int _currentIndex = 0;
		private List<Transform> _waypoints;
		void Awake()
		{
			_waypoints = _waveConfig.Waypoints.ToList();
			// start at the first waypoint.
			transform.position = _waypoints[_currentIndex].position;
		}

		void Update()
		{
			MoveTowardsWavePoint();
		}

		private void MoveTowardsWavePoint()
		{
			// haven't reached the end of the waypoints path yet, move towards the next one
			if(_currentIndex <= _waypoints.Count - 1)
			{
				var targetPosition = _waypoints[_currentIndex].transform.position;
				var frameMovement = _moveSpeed * Time.deltaTime;

				transform.position = Vector2.MoveTowards(transform.position, targetPosition, frameMovement);

				// have we reached the position we are going to, next waypoint
				if(transform.position == targetPosition)
				{
					_currentIndex++;
				}
			}
			else
			{
				Destroy(gameObject);
			}
		}
	}

}