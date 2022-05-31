using UnityEngine;
using GameElements;
using GameSystem;

namespace EntitiesHomework
{
    public class ShootController : MonoBehaviour, 
        IGameReadyElement, 
        IGameFinishElement
    {
        private PlayerService playerService;
        private InputManager inputManager;
        private MouseManager mouseManager;

        void IGameReadyElement.ReadyGame(GameElements.IGameSystem system)
        {
            this.playerService = system.GetService<PlayerService>();
            this.inputManager = system.GetService<InputManager>();
            this.mouseManager = system.GetService<MouseManager>();
            
            this.inputManager.OnFire += this.OnInputEvent;
            this.mouseManager.OnFire += this.OnInputEvent;
        }

        void IGameFinishElement.FinishGame(GameElements.IGameSystem system)
        {
            this.inputManager.OnFire -= this.OnInputEvent;
            this.mouseManager.OnFire -= this.OnInputEvent;
        }

        private void OnInputEvent()
        {
            this.playerService.Player.Element<IShootComponent>().Shoot();
        }
    }
}