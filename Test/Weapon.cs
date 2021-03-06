﻿using UnityEngine;


namespace JevLogin
{
    public sealed class Weapon : MonoBehaviour
    {
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out var hit, 15.0f))
                {
                    if (hit.collider.TryGetComponent(out IEnemy enemy))
                    {
                        switch (enemy)
                        {
                            case ILoggerSecond loggerSecond:
                                loggerSecond.Log();
                                break;
                            case IDamagable damagable:
                                damagable.AddDamage();
                                break;

                            default:
                                Debug.Log($"Ничего не произошло");
                                break;
                        }
                    }

                }
            }
        }
    }
}
