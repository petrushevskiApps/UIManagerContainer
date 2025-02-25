using System.Collections;
using System.Collections.Generic;
using PetrushevskiApps.UIManager;
using UnityEngine;

namespace slowBulletGames.MemoryValley
{
    public class LevelFailedPopup : UIPopup
    {
        [SerializeField] private UIButton replayButton;
        [SerializeField] private UIButton homeButton;

        private void Awake()
        {
            replayButton.onClick.AddListener(OnReplayClicked);
            homeButton.onClick.AddListener(OnHomeClicked);
        }
        private void OnReplayClicked()
        {
            Close();
        }

        private void OnHomeClicked()
        {
            Close();
        }
        public void OnBackButtonPressed()
        {
            OnHomeClicked();
        }
    }
}
