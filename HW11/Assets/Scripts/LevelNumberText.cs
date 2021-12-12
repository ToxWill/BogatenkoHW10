using System.Collections;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.Scripts
{
    public class LevelNumberText : MonoBehaviour
    {
        public Text Text;
        public Text LevelNumber;
        public Text NextLevelNumber;
        public Game Game;

        private void Start()
        {
            Text.text = "Level " + (Game.LevelIndex + 1).ToString();
            LevelNumber.text = "" + (Game.LevelIndex + 1).ToString();
            NextLevelNumber.text = "" + (Game.LevelIndex + 2).ToString();
        }
    }
}