namespace GameSystem
{
    public interface IGameSystem
    {
        void InitGame();
        void StartGame();
        void PauseGame();
        void ResumeGame();
        void FinishGame();

        T GetService<T>();
    }
}