using System;
using UnityEngine;
using Entities;

namespace EntitiesHomework
{
    public class MoveController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        private IMoveComponent moveComponent;

        private void Start()
        {
            this.moveComponent = this.player.Element<IMoveComponent>();
        }

        private void Update()
        {
            if (Input.GetAxis("Horizontal") != 0f)
            {
                this.moveComponent.Move(new Vector3(Input.GetAxis("Horizontal"), 0f, 0f));
            }
            
            if (Input.GetAxis("Vertical") != 0f)
            {
                this.moveComponent.Move(new Vector3(0f, 0f, Input.GetAxis("Vertical")));
            }
        }
    }
}