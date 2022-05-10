using UnityEngine;
using Entities;

namespace EntitiesHomework
{
    public class RotateController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        private IRotateComponent rotateComponent;

        private void Start()
        {
            this.rotateComponent = this.player.Element<IRotateComponent>();
        }

        private void Update()
        {
            if (Input.GetAxis("Mouse X") != 0f || Input.GetAxis("Mouse Y") != 0f)
            {
                this.rotateComponent.Rotate(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
            }
        }
    }
}