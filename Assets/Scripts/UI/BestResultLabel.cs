using UnityEngine;
using UnityEngine.UI;

namespace BallClicker
{
    public class BestResultLabel : MonoBehaviour
    {
        
        [SerializeField] private Text label;
        private void OnEnable()
        {
            label.text = "Best result: " + SaveLoadData.BestResult;
        }
    }
}