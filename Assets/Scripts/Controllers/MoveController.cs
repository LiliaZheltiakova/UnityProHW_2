using UnityEngine;
using GameElements;
using GameSystem;

namespace EntitiesHomework
{
    public class MoveController : MonoBehaviour, 
        IGameReadyElement, 
        IGameFinishElement

    {
        private PlayerService playerService;
        private InputManager inputManager;

        void IGameReadyElement.ReadyGame(GameElements.IGameSystem system)
        {
            this.playerService = system.GetService<PlayerService>();
            this.inputManager = system.GetService<InputManager>();
            this.inputManager.OnInput += this.OnInputEvent;
        }

        void IGameFinishElement.FinishGame(GameElements.IGameSystem system)
        {
            this.inputManager.OnInput -= this.OnInputEvent;
        }

        private void OnInputEvent(Vector3 direction)
        {
            this.playerService.Player.Element<IMoveComponent>().Move(direction);
        }
    }
}