using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BallClicker
{
    [RequireComponent(typeof(MeshRenderer))]
    public class Ball : MonoBehaviour, IReward, IDamage, IDestroyable
    {
        [SerializeField] private ParticleSystem particlePrefab;
        private int _reward;
        private int _damage;
        private Color _color;
        public int Reward => _reward;
        public int Damage => _damage;
        

        public void Constructor(int reward, int damage, float speed,  Color color)
        {
            _reward = reward;
            _damage = damage;
            _color = color;
            gameObject.AddComponent<BallMovement>().SetSpeed(speed);
            GetComponent<MeshRenderer>().material.color = _color;
        }

        public void DestroyObject(bool explosion)
        {
            if (explosion)
            {
                ParticleSystem particle = Instantiate(particlePrefab, transform.position, Quaternion.identity);
                var particleMain = particle.main;
                particleMain.startColor = _color;
            }
            Destroy(gameObject);
        }
    }
}