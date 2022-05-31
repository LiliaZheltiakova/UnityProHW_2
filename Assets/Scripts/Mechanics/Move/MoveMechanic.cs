using System;
using UnityEngine;

namespace EntitiesHomework
{
    public class MoveMechanic : MonoBehaviour
    {
        public event Action<Vector3> OnMove;
        public void Move(Vector3 direction)
        {
            this.OnMove?.Invoke(direction);
        }
    }
}