using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Gameplay;

namespace Assets.Scripts.Player
{
    public class HealthDisplayer : MonoBehaviour
    {
        private Text _healthText;
        [SerializeField] private Player _currentPlayer;

        // Use this for initialization
        void Start()
        {
            _healthText = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            _healthText.text = _currentPlayer.CurrentHealth.ToString();
        }
    }
}
