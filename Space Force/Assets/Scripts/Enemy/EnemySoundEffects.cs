using Assets.Scripts.Gameplay;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    [CreateAssetMenu(menuName = "Enemy Sound Effects")]
    public class EnemySoundEffects : ScriptableObject
    {
        [SerializeField] private SoundEffectOptions _enemyDeathSoundConfig;
        [SerializeField] private SoundEffectOptions _enemyShootSoundConfig;

        public SoundEffectOptions DeathSound
        {
            get
            {
                return _enemyDeathSoundConfig;
            }
        }

        public SoundEffectOptions ShootSound
        {
            get
            {
                return _enemyShootSoundConfig;
            }
        }
    }
}
