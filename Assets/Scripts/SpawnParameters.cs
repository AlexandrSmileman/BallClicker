using UnityEngine;

namespace BallClicker
{
    [CreateAssetMenu(fileName = "SpawnParameters", menuName = "Scriptable/SpawnParameters")]
    public class SpawnParameters : ScriptableObject
    {
        public float minSpeed;
        public float maxSpeed;
        public float acceleration;
        public int minReward;
        public int maxReward;
        public int minDamage;
        public int maxDamage;
        public float spawnDelay;
    }
}