﻿using UnityEngine;

namespace Code.Runtime.Gameplay.Logic
{
    internal class MoverX : MonoBehaviour
    {
        [SerializeField] 
        private Rigidbody2D _rigidbody;
        
        [SerializeField] 
        private float _speed = 5f;

        public float Speed => _rigidbody.velocity.x;
        public bool IsMoving => _rigidbody.velocity.x != 0;

        public void Move(float input)
        {
            _rigidbody.velocity = new Vector2(input * _speed, _rigidbody.velocity.y);
        }
    }
}