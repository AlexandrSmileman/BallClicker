using UnityEngine.UI;
using UnityEngine;

namespace BallClicker
{
    public class CountLabel : MonoBehaviour
    {
        [SerializeField] private string label;
        [SerializeField] private Counter counter;

        private Text textLabel;

        private void Start()
        {
            textLabel = GetComponent<Text>();
            SetCount(counter.GetCount);
            counter.OnCountChanged += SetCount;
        }

        private void SetCount(int value)
        {
            textLabel.text = label + ": " + value;
        }
    }
}