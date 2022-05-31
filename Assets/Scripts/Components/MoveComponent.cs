using System;
using UnityEngine;

namespace EntitiesHomework
{
    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField] private MoveMechanic controller;
        public void Move(Vector3 direction)
        {
            this.controller.Move(direction);
        }
    }
}