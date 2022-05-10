using System;
using UnityEngine;

namespace EntitiesHomework
{
    public class TakeDamageComponent : MonoBehaviour, ITakeDamageComponent
    {
        [SerializeField] private TakeDamageMechanic controller;

        public void TakeDamage(int damage)
        {
            this.controller.TakeDamage(damage);
        }
    }
}