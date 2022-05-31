using System;
using UnityEngine;

namespace EntitiesHomework
{
    public class RotateHandler : MonoBehaviour
    {
        [SerializeField] private RotateMechanic rotateMechanic;
        [SerializeField] private Transform rotateTransform;

        private void OnEnable()
        {
            this.rotateMechanic.OnRotate += this.OnRotate;
        }

        private void OnDisable()
        {
            this.rotateMechanic.OnRotate -= this.OnRotate;
        }

        private void OnRotate(Vector2 rotateAxis)
        {
            this.rotateTransform.transform.Rotate(Vector3.up, rotateAxis.x);
            this.rotateTransform.transform.Rotate(Vector3.right, -rotateAxis.y);
        }
    }
}