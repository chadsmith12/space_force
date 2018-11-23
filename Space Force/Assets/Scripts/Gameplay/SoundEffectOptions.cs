using System;
using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    [Serializable]
    public struct SoundEffectOptions
    {
        public AudioClip AudioClip;

        [Range(0, 1.0f)]
        public float Volume;

        /// <summary>
        /// Plays this sound effect at the given position.
        /// </summary>
        /// <param name="position">The position to play the sound effect at.</param>
        public void Play(Vector2 position)
        {
            AudioSource.PlayClipAtPoint(AudioClip, position, Volume);
        }

        /// <summary>
        /// Plays this sound effect at the main cameras position.
        /// </summary>
        public void Play()
        {
            Play(Camera.main.transform.position);
        }
    }
}
