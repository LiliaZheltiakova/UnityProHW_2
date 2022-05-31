using System;
using UnityEngine;

namespace GameSystem
{
    public sealed class GameSystem : MonoBehaviour, IGameSystem
    {
        [SerializeField] private MonoBehaviour[] components;

        private void Awake()
        {
            foreach (var component in components)
            {
                if (component is IGameComponent gameComponent)
                {
                    gameComponent.GameSystem = this;
                }
            }
        }

        public void InitGame()
        {
            foreach (var component in components)
            {
                if (component is IGameInitComponent initComponent)
                {
                    initComponent.OnInitGame();
                }
            }
        }

        public void StartGame()
        {
            foreach (var component in components)
            {
                if (component is IGameStartComponent startComponent)
                {
                    startComponent.OnStartGame();
                }
            }
        }

        public void PauseGame()
        {
            foreach (var component in components)
            {
                if (component is IGamePauseComponent pauseComponent)
                {
                    pauseComponent.OnPauseGame();
                }
            }
        }

        public void ResumeGame()
        {
            foreach (var component in components)
            {
                if (component is IGameResumeComponent resumeComponent)
                {
                    resumeComponent.OnResumeGame();
                }
            }
        }

        public void FinishGame()
        {
            foreach (var component in components)
            {
                if (component is IGameFinishComponent finishComponent)
                {
                    finishComponent.OnFinishGame();
                }
            }
        }

        public T GetService<T>()
        {
            foreach (var component in components)
            {
                if (component is T tComponent)
                {
                    return tComponent;
                }
            }

            throw new Exception($"Component {typeof(T).Name} wasn't found!");
        }
    }
}