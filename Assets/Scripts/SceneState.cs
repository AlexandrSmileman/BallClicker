using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BallClicker
{
    public class SceneState : MonoBehaviour
    {
        public void Pause()
        {
            Time.timeScale = 0f;
        }

        public void Play()
        {
            Time.timeScale = 1f;
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void Quit()
        {
            OnQuit();
            Application.Quit();
        }

        private void OnQuit()
        {
            //do stuff
        }
    }
}