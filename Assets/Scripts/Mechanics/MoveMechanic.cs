using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EntitiesHomework
{
    public class MoveMechanic : MonoBehaviour
    { 
        public float MoveSpeed => this.moveSpeed;

        [SerializeField] private float moveSpeed;
        [SerializeField] private Transform moveTransform;

        public void Move(Vector3 direction)
        {
            this.moveTransform.position += direction * (Time.deltaTime * this.moveSpeed);
        }
    }
}