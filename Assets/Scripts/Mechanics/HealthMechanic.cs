using System;
using UnityEngine;
using UnityEngine.Events;

namespace EntitiesHomework
{
    public class HealthMechanic : MonoBehaviour
    {
        public event Action<int> OnHealthChanged;
        public int Health => this.health;

        [Range(0,100)]
        [SerializeField] private int health;

        [SerializeField] private UnityEvent<int> onChangeHealth;
        [SerializeField] private UnityEvent onHealthZero;

        public void IncrementHealth(int range)
        {
            this.health += range;
            this.UpdatedHealthEvents();
        }

        public void DecrementHealth(int range)
        {
            this.health = Math.Max(this.health -= range, 0);
            this.UpdatedHealthEvents();
        }

        public void ChangeHealth(int newHealth)
        {
            this.health = Math.Max(newHealth, 0);
            this.UpdatedHealthEvents();
        }

        private void UpdatedHealthEvents()
        {
            this.OnHealthChanged?.Invoke(this.health);
            this.onChangeHealth?.Invoke(this.health);
            
            if (this.health <= 0)
            {
                this.onHealthZero?.Invoke();
            }
        }
    }
}