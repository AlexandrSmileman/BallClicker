using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BallClicker
{
    public class BallMovement : MonoBehaviour
    {
        private float _speed;
        public void SetSpeed(float speed)
        {
            _speed = speed;
        }
        void Update()
        {
            transform.position += Vector3.down * Time.deltaTime * _speed;
        }
    }
}