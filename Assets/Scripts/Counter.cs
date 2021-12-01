using System;
using UnityEngine;

namespace BallClicker
{
    public class Counter : MonoBehaviour
    {
        [SerializeField]
        protected int count;
        public int GetCount => count;
        public event Action<int> OnCountChanged;

        public virtual void AddCount(int value)
        {
            count += value;
            OnCountChanged?.Invoke(count);
        }
    }
}