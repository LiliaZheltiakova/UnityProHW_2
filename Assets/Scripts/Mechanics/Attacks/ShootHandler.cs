using System;
using UnityEngine;

namespace EntitiesHomework.Attacks
{
    public class ShootHandler : MonoBehaviour
    {
        [SerializeField] private ShootMechanic shootMechanic;

        private void OnEnable()
        {
            this.shootMechanic.OnShoot += this.OnShoot;
        }

        private void OnDisable()
        {
            this.shootMechanic.OnShoot -= this.OnShoot;
        }

        private void OnShoot()
        {
            Debug.Log("Piu Piu!");
        }
    }
}