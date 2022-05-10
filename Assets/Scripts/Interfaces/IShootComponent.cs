using System;
using UnityEngine;

namespace EntitiesHomework
{
    public interface IShootComponent
    {
        event Action OnShooted;
        void Shoot();
    }
}