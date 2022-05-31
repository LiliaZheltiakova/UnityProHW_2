using UnityEngine;

namespace EntitiesHomework
{
    public class MoveHandler_Transform : MonoBehaviour
    {
        [SerializeField] private MoveMechanic moveMechanic;
        [SerializeField] private Transform moveTransform;

        [SerializeField] private MoveSpeedMechanic speedMechanic;


        private void OnEnable()
        {
            this.moveMechanic.OnMove += this.OnMove;
        }

        private void OnDisable()
        {
            this.moveMechanic.OnMove -= this.OnMove;
        }

        private void OnMove(Vector3 direction)
        {
            this.moveTransform.transform.position += direction * (Time.deltaTime * this.speedMechanic.MoveSpeed);
        }
    }
}