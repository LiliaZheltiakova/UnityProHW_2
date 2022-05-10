using System;
using Entities;
using UnityEngine;

namespace EntitiesHomework
{
    public class HealthController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;

        private IHealthComponent healthComponent;

        private void OnEnable()
        {
            this.healthComponent = this.player.Element<IHealthComponent>();
            this.healthComponent.OnHealthChanged += this.OnPlayerHealthChanged;
        }

        private void OnPlayerHealthChanged(int health)
        {
            Debug.Log($"Player health changed: {health}");
        }

        private void OnDisable()
        {
            this.healthComponent.OnHealthChanged -= this.OnPlayerHealthChanged;
        }
    }
}