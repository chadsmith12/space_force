using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class LevelManagmentEvents : MonoBehaviour
    {
        public void StartGame()
        {
            LevelManagment.LoadGame();
        }

        public void QuitGame()
        {
            LevelManagment.QuitGame();
        }
    }
}
