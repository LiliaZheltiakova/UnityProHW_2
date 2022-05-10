using Entities;
using UnityEngine;

namespace EntitiesHomework
{
    public class DieController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;

        private void OnEnable()
        {
            var dieComponent = this.player.Element<IDieComponent>();
            dieComponent.OnDied += this.OnPlayerDied;
        }

        private void OnPlayerDied()
        {
            Debug.Log("Player died");
        }

        private void OnDisable()
        {
            var dieComponent = this.player.Element<IDieComponent>();
            dieComponent.OnDied -= this.OnPlayerDied;
        }
    }
}