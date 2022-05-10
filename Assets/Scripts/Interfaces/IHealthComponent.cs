using System;

namespace EntitiesHomework
{
    public interface IHealthComponent
    {
        event Action<int> OnHealthChanged;
        int Health { get; }
    }
}