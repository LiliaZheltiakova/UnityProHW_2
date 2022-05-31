using System;
using UnityEngine;

namespace EntitiesHomework.Attacks
{
    public class ShootMechanic : MonoBehaviour
    {
        public event Action OnShoot;
        public void Shoot()
        {
            OnShoot?.Invoke();
        }
    }
}