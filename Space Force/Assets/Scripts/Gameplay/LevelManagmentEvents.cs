using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class LevelManagmentEvents : MonoBehaviour
    {
        public void StartMenu()
        {
            LevelManagment.LoadStartMenu();
        }

        public void StartGame()
        {
            LevelManagment.LoadGame();
            GameSession.Instance.ResetGame();
        }

        public void QuitGame()
        {
            LevelManagment.QuitGame();
        }
    }
}
