﻿using UnityEngine;


namespace JevLogin
{
    public sealed class PlayerBall : Player
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}