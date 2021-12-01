using System;
using UnityEngine;

namespace BallClicker
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private Counter counter;
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IDamage damage))
            {
                counter.AddCount(-damage.Damage);
            }
            if (other.TryGetComponent(out IDestroyable destroyable))
            {
                destroyable.DestroyObject(false);
            }
        }

        
    }
}