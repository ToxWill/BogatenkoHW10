using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformNumberText : MonoBehaviour
{
    public Text TextOfPlatfroms;
    public Player Player;

    private void Update()
    {
        TextOfPlatfroms.text = Player.ThisPlatform.ToString();
    }
}
