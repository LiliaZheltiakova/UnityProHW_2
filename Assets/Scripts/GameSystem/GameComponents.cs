namespace GameSystem
{
    public interface IGameComponent
    {
        IGameSystem GameSystem { set; }
    }
    public interface IGameInitComponent
    {
        void OnInitGame();
    }
    
    public interface IGameStartComponent
    {
        void OnStartGame();
    }

    public interface IGameFinishComponent
    {
        void OnFinishGame();
    }
    
    public interface IGamePauseComponent
    {
        void OnPauseGame();
    }
    
    public interface IGameResumeComponent
    {
        void OnResumeGame();
    }
}