
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BallClicker
{
    public class BallSpawner : MonoBehaviour
    {
        [SerializeField] private float borderOffset = 1f;
        [SerializeField] private SpawnParameters parameters;
        [SerializeField] private Ball ballPrefab;

        private float _spawnTimer;
        private float _acceleration;
        private float _leftBorder;
        private float _rightBorder;
        private float _height;

        private void Start()
        {
            _leftBorder = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x + borderOffset;
            _rightBorder = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x - borderOffset;
            _height = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 1f;
        }

        private void Update()
        {
            _spawnTimer += Time.deltaTime;
            _acceleration += parameters.acceleration;
            if (_spawnTimer < parameters.spawnDelay)
                return;

            _spawnTimer = 0;
            SpawnBall(new Vector3(Random.Range(_leftBorder, _rightBorder), _height, 0));
        }

        private void SpawnBall(Vector3 position)
        {
            
            int reward = Random.Range(parameters.minReward, parameters.maxReward + 1);
            int damage = Random.Range(parameters.minDamage, parameters.maxDamage + 1);
            float speed = Random.Range(parameters.minSpeed, parameters.maxSpeed) + _acceleration;
            Color color = GetRandomColor();
            Ball ball = Instantiate(ballPrefab, position, Quaternion.identity);
            ball.Constructor(reward, damage, speed, color);
        }

        private Color GetRandomColor()
        {
            int rnd1 = Random.Range(1, 4);
            int rnd2 = Random.Range(0, 2);
            switch (rnd1)
            {
                case 1:
                    return new Color(Random.Range(0f, 1f), rnd2, 1 - rnd2, 1f);
                case 2:
                    return new Color(rnd2, Random.Range(0f, 1f), 1 - rnd2, 1f);
                case 3:
                    return new Color(rnd2,  1 - rnd2,Random.Range(0f, 1f), 1f);
            }

            return Color.white;
        }
    }
}