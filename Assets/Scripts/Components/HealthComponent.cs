using System;
using UnityEngine;

namespace EntitiesHomework
{
    public sealed class HealthComponent : MonoBehaviour, IHealthComponent
    {
        public event Action<int> OnHealthChanged
        {
            add => this.controller.OnHealthChanged += value;
            remove => this.controller.OnHealthChanged -= value;
        }
        public int Health => this.controller.Health;

        [SerializeField] private HealthMechanic controller;
    }
}