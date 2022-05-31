using UnityEngine;

namespace EntitiesHomework
{
    public class MoveSpeedMechanic : MonoBehaviour
    {
        public float MoveSpeed => this.moveSpeed;
        [SerializeField] private float moveSpeed;
    }
}