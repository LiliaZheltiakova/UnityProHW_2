using System;
using UnityEngine;

namespace EntitiesHomework
{
    public class DieComponent : MonoBehaviour, IDieComponent
    {
        public event Action OnDied
        {
            add => this.controller.OnDied += value;
            remove => this.controller.OnDied -= value;
        }

        [SerializeField] private DieMechanic controller;

        public void Die()
        {
            this.controller.Die();
        }
        
    }
}