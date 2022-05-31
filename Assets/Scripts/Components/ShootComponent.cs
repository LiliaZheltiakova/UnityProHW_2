using System;
using EntitiesHomework.Attacks;
using UnityEngine;

namespace EntitiesHomework
{
    public class ShootComponent : MonoBehaviour, IShootComponent
    {
        [SerializeField] private ShootMechanic controller;
        public void Shoot()
        {
            this.controller.Shoot();
        }
    }
}