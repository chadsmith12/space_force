using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class MusicPlayer : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            SetupSingleton();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void SetupSingleton()
        {
            if(FindObjectsOfType(GetType()).Length > 1)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}

