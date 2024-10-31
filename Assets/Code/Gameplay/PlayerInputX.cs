using UnityEngine;

namespace Code.Gameplay
{
    public class PlayerInputX : MonoBehaviour
    {
        private const string AxisHorizontal = "Horizontal";

        [SerializeField] 
        private MoverX _mover;

        void Update()
        {
            float input = Input.GetAxis(AxisHorizontal);
            _mover.Move(input);
        }
    }
}