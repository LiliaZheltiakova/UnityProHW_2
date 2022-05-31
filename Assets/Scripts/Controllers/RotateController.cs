using UnityEngine;
using Entities;
using GameElements;
using GameSystem;

namespace EntitiesHomework
{
    public class RotateController : MonoBehaviour, 
        IGameReadyElement, 
        IGameFinishElement
    {
        private PlayerService playerService;
        private MouseManager mouseManager;

        void IGameReadyElement.ReadyGame(GameElements.IGameSystem system)
        {
            this.playerService = system.GetService<PlayerService>();
            this.mouseManager = system.GetService<MouseManager>();
            this.mouseManager.OnInput += this.OnInputEvent;
        }
        
        void IGameFinishElement.FinishGame(GameElements.IGameSystem system)
        {
            this.mouseManager.OnInput -= this.OnInputEvent;
        }
        
        private void OnInputEvent(Vector2 rotateAxes)
        {
            this.playerService.Player.Element<IRotateComponent>().Rotate(rotateAxes);
        }
    }
}