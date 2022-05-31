using GameElements;
using GameSystem;
using UnityEngine;
using IGameSystem = GameElements.IGameSystem;

namespace EntitiesHomework
{
    public class InputController : MonoBehaviour,
        IGameStartElement,
        IGameFinishElement
    {
        private InputManager inputManager;
        void IGameStartElement.StartGame(IGameSystem system)
        {
            this.inputManager = system.GetService<InputManager>();
            this.inputManager.enabled = true;
        }

        void IGameFinishElement.FinishGame(IGameSystem system)
        {
            this.inputManager.enabled = false;
        }
    }
}