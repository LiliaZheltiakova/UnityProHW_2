using GameElements;
using UnityEngine;

namespace Other
{
    public class DynamicObject : MonoBehaviour,
        IGameStartElement,
        IGameFinishElement
    {
        void IGameStartElement.StartGame(IGameSystem system)
        {
            Debug.Log("Start");
        }

        void IGameFinishElement.FinishGame(IGameSystem system)
        {
            Debug.Log("Finish");
        }
    }
}