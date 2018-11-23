using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class SoundEffectPlayer : MonoBehaviour
    {
        [SerializeField] private AudioClip _soundEffect;
        [Range(0, 1.0f)]
        [SerializeField] private float _volume = 0.75f;

        public void PlaySound(Vector2 position)
        {
            AudioSource.PlayClipAtPoint(_soundEffect, position, _volume);
        }
    }
}
