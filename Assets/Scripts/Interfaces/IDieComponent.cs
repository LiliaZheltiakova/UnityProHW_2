using System;

namespace EntitiesHomework
{
    public interface IDieComponent
    {
        event Action OnDied;

        void Die();
    }
}