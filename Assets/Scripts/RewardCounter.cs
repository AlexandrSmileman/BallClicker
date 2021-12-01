using System;
using UnityEngine;

namespace BallClicker
{
    public class RewardCounter : Counter
    {
        private int bestResult;

        private void Start()
        {
            bestResult = SaveLoadData.BestResult;
        }

        public override void AddCount(int value)
        {
            base.AddCount(value);
            if (count > bestResult)
            {
                SaveLoadData.SaveBestResult(count);
                bestResult = count;
            }
        }
    }
}