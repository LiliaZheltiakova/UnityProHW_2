using UnityEngine;
using UnityEngine.Events;

namespace EntitiesHomework
{
    public class TakeDamageMechanic: MonoBehaviour
    {
        [SerializeField] private UnityEvent<int> OnTakeDamage;
        public void TakeDamage(int damage)
        {
            this.OnTakeDamage?.Invoke(damage); 
        }
    }
}