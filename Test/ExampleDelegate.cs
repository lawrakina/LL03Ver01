﻿using UnityEngine;


namespace JevLogin
{
    public sealed class ExampleDelegate : MonoBehaviour
    {
        private void Start()
        {
            Example exampleDelegate = new Example();

            exampleDelegate.Test();
            exampleDelegate.StartDelegate();
        }
    }
}