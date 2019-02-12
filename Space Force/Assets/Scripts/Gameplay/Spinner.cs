using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    public class Spinner : MonoBehaviour
    {
        [SerializeField] float _speedOfSpin = 1f;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(0, 0, _speedOfSpin * Time.deltaTime));
        }
    }
}
