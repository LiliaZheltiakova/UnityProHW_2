using System;
using UnityEngine;

namespace GameSystem
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private GameSystem gameSystem;

        private void Start()
        {
            this.gameSystem.InitGame();
            this.gameSystem.StartGame();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.gameSystem.FinishGame();
            }
        }
    }
}