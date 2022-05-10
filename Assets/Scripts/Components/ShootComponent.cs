using System;
using EntitiesHomework.Attacks;
using UnityEngine;

namespace EntitiesHomework
{
    public class ShootComponent : MonoBehaviour, IShootComponent
    {
        [SerializeField] private ShootMechanic controller;
        
        public event Action OnShooted
        {
            add => this.controller.OnShooted += value;
            remove => this.controller.OnShooted -= value;
        }
        public void Shoot()
        {
            this.controller.Shoot();
        }
    }
}