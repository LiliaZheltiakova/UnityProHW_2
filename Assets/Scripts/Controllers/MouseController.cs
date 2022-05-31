using GameElements;
using GameSystem;
using UnityEngine;
using IGameSystem = GameElements.IGameSystem;

namespace EntitiesHomework
{
    public class MouseController : MonoBehaviour,
        IGameStartElement,
        IGameFinishElement
    {
        private MouseManager mouseManager;
        void IGameStartElement.StartGame(IGameSystem system)
        {
            this.mouseManager = system.GetService<MouseManager>();
            this.mouseManager.enabled = true;
        }

        void IGameFinishElement.FinishGame(IGameSystem system)
        {
            this.mouseManager.enabled = false;
        }
    }
}