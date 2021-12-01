using System;
using UnityEngine;

namespace BallClicker
{
    public class DeathHandler : MonoBehaviour
    {
        [SerializeField] private Counter counter;
        [SerializeField] private SceneState sceneState;
        [SerializeField] private GameObject pausePanel;
        [SerializeField] private GameObject playButton;

        private void Start()
        {
            counter.OnCountChanged += CheckHealth;
        } 

        private void CheckHealth(int health)
        {
            if (health > 0)
                return;

            sceneState.Pause();
            pausePanel.SetActive(true);
            playButton.SetActive(false);

        }
    }
}