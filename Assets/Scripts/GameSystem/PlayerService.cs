using Entities;
using UnityEngine;

namespace GameSystem
{
    public class PlayerService : MonoBehaviour
    {
        public IEntity Player => this.player;

        [SerializeField] private MonoEntity player;
    }
}