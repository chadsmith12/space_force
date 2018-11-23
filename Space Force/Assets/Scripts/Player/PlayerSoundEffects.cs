using Assets.Scripts.Gameplay;
using UnityEngine;

namespace Assets.Scripts.Player
{
    [CreateAssetMenu(menuName = "Player Sound Effects")]
    public class PlayerSoundEffects : ScriptableObject
    {
        [SerializeField] private SoundEffectOptions _playerDeathSoundConfig;
        [SerializeField] private SoundEffectOptions _playerShootSoundConfig;

        public SoundEffectOptions DeathSound
        {
            get
            {
                return _playerDeathSoundConfig;
            }
        }

        public SoundEffectOptions ShootSound
        {
            get
            {
                return _playerShootSoundConfig;
            }
        }
    }
}
