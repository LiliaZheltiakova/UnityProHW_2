using System;
using UnityEngine;

namespace EntitiesHomework
{
    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField] private MoveMechanic controller;

        public float MoveSpeed => this.controller.MoveSpeed;
        public void Move(Vector3 direction)
        {
            this.controller.Move(direction);
        }
    }
}