using slowBulletGames.MemoryValley;
using UnityEngine;

namespace MenuManager.Scripts.Adapters
{
    public class LevelController: IUILevelController
    {
        public void StartLevel()
        {
            Debug.Log("StartNextLevel");
        }

        public void RestartLevel()
        {
            Debug.Log("RestartLevel");
        }

        public void ReviveAndContinueLevel()
        {
            Debug.Log("ReviveAndContinueLevel");
        }

        public void CollectReward()
        {
            Debug.Log("CollectReward");
        }

        public void CollectDoubleReward()
        {
            Debug.Log("CollectDoubleReward");
        }

        public void LeaveLevel()
        {
            Debug.Log("Leave Level");
        }
    }
}