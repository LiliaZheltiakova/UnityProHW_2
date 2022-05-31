using System;
using UnityEngine;

namespace GameSystem
{
    public class MouseManager : MonoBehaviour, IGameStartComponent, IGameFinishComponent
    {
        public event Action<Vector2> OnInput;
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
            if (Input.GetAxis("Mouse X") != 0f || Input.GetAxis("Mouse Y") != 0f)
            {
                this.OnInput?.Invoke(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
            }

            if (Input.GetMouseButton(0))
            {
                this.OnFire?.Invoke();
            }
        }
    }
}