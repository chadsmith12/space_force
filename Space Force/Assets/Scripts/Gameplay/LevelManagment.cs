using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Gameplay
{
    /// <summary>
    /// Helper class to manage the loading of the different levels and scenes in the game.
    /// </summary>
    public class LevelManagment
    {
        /// <summary>
        /// Loads the start menu (first scene in the game) of the game.
        /// </summary>
        public static void LoadStartMenu()
        {
            SceneManager.LoadScene(0);
        }

        /// <summary>
        /// Loads the main game scene immediately.
        /// </summary>
        public static void LoadGame()
        {
            SceneManager.LoadScene("Game");
        }

        /// <summary>
        /// Loads the game scene after a delay.
        /// Runs as a coroutine.
        /// </summary>
        /// <param name="delay">The delay in seconds.</param>
        public static IEnumerator LoadGame(float delay)
        {
            yield return new WaitForSeconds(delay);
            LoadGame();
        }

        /// <summary>
        /// Loads the game over scene immeidately.
        /// </summary>
        public static void LoadGameOver()
        {
            SceneManager.LoadScene("GameOver");
        }

        /// <summary>
        /// Quits out of the game.
        /// </summary>
        public static void QuitGame()
        {
            Application.Quit();
        }
    }
}

