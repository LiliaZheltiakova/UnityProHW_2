using System;
using UnityEngine;
using UnityEngine.Events;

namespace EntitiesHomework
{
    public class DieMechanic : MonoBehaviour
    {
        public event Action OnDied;
        [SerializeField] private UnityEvent OnDie;

        public void Die()
        {
            this.OnDied?.Invoke();
            this.OnDie?.Invoke();
        }
        
    }
}