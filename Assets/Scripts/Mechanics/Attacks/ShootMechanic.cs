using System;
using UnityEngine;

namespace EntitiesHomework.Attacks
{
    public class ShootMechanic : MonoBehaviour
    {
        public event Action OnShooted;
        public void Shoot()
        {
            Debug.Log("Piu piu!");
            OnShooted?.Invoke();
        }
    }
}