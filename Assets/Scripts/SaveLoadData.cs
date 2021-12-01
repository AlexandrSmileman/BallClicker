using UnityEngine;

namespace BallClicker
{
    public static class SaveLoadData
    {
        private static string _bestResult = "BestResult";
        public static int BestResult => PlayerPrefs.GetInt(_bestResult);

        public static void SaveBestResult(int value)
        {
            PlayerPrefs.SetInt(_bestResult, value);
        }
            
    }
}