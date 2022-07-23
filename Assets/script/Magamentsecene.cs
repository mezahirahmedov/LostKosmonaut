using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magamentsecene : MonoBehaviour
{
    public Text Score;
    public Transform player;
    

    void Update()
    {
        Score.text = player.position.y.ToString("0");
        
    }
}
