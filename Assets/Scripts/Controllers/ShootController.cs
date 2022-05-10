using System;
using Entities;
using UnityEngine;

namespace EntitiesHomework
{
    public class ShootController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        private IShootComponent attackComponent;

        private void OnEnable()
        {
            this.attackComponent = this.player.Element<IShootComponent>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                attackComponent.Shoot();
            }
        }
    }
}