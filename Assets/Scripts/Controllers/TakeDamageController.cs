using System;
using Entities;
using UnityEngine;

namespace EntitiesHomework
{
    public class TakeDamageController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        private ITakeDamageComponent damageComponent;

        private void Start()
        {
            this.damageComponent = this.player.Element<ITakeDamageComponent>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                damageComponent.TakeDamage(1); 
            }
        }
    }
}