using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class GameSession : MonoBehaviour
    {
        /// <summary>
        /// The current instance of this game session instance.
        /// </summary>
        public static GameSession Instance { get; private set; }

        /// <summary>
        /// The current score for this game session.
        /// </summary>
        public int CurrentScore { get; private set; }

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        /// <summary>
        /// Adds the score value to the current score of this game session.
        /// </summary>
        /// <param name="scoreValue">How much to add to the score.</param>
        public void AddToScore(int scoreValue)
        {
            CurrentScore += scoreValue;
        }

        /// <summary>
        /// Destroys this current game session to reset it.
        /// </summary>
        public void ResetGame()
        {
            Destroy(gameObject);
        }
    }
}

