using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Player
{
    public class ScoreDisplayer : MonoBehaviour
    {
        private Text _scoreText;

        // Use this for initialization
        void Start()
        {
            _scoreText = GetComponent<Text>(); 
        }

        // Update is called once per frame
        void Update()
        {
            _scoreText.text = Gameplay.GameSession.Instance.CurrentScore.ToString();
        }
    }
}

