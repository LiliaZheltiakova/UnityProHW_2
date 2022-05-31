using System;
using UnityEngine;

namespace EntitiesHomework
{
    public class RotateMechanic : MonoBehaviour
    {
        public event Action<Vector2> OnRotate;
        public void Rotate(Vector2 rotateAxis)
        {
            this.OnRotate?.Invoke(rotateAxis);
        }
    }
}