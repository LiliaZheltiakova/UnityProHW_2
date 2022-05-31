using System;
using UnityEngine;

namespace GameSystem
{
    public class InputManager : MonoBehaviour, IGameStartComponent, IGameFinishComponent
    {
        public event Action<Vector3> OnInput;
        public event Action OnFire;

        private void Awake()
        {
            this.enabled = false;
        }

        void IGameStartComponent.OnStartGame()
        {
            this.enabled = true;
        }

        void IGameFinishComponent.OnFinishGame()
        {
            this.enabled = false;
        }
        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                this.OnInput?.Invoke(Vector3.left);
            }
            
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                this.OnInput?.Invoke(Vector3.right);
            }
            
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                this.OnInput?.Invoke(Vector3.forward);
            }
            
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                this.OnInput?.Invoke(Vector3.back);
            }

            if (Input.GetKey(KeyCode.F))
            {
                this.OnFire?.Invoke();
            }
        }
    }
}