﻿using UnityEngine;

namespace Code.Runtime.Gameplay.Logic
{
    public class Wallet: MonoBehaviour
    {
        [SerializeField]
        private int _balance;
        
        public void AddCoin() =>
            _balance++;
    }
}