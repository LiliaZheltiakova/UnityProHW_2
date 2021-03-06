using UnityEngine;

namespace EntitiesHomework
{
    public class RotateComponent : MonoBehaviour, IRotateComponent
    {
        [SerializeField] private RotateMechanic controller;
        public void Rotate(Vector2 rotateAxis)
        {
            this.controller.Rotate(rotateAxis);
        }
    }
}