using System;
using UnityEngine;
namespace EntitiesHomework
{
    public interface IMoveComponent
    {
        float MoveSpeed { get; }
        void Move(Vector3 direction);
    }
}
