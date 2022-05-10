using UnityEngine;

namespace EntitiesHomework
{
    public class RotateMechanic : MonoBehaviour
    {
        [SerializeField] private Transform rotateTransform;
        [SerializeField] private float rotateSpeed;
        public void Rotate(Vector2 mousePositionOnScreen)
        {
            this.rotateTransform.transform.Rotate(Vector3.up, mousePositionOnScreen.x);
            this.rotateTransform.transform.Rotate(Vector3.right, -mousePositionOnScreen.y);
        }
    }
}