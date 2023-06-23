using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Coin : MonoBehaviour
{
    bool playerwin = false;
    private void Update()
    {
        if (playerwin)
        GUI.Box(new Rect(Screen.width * (1 / 2) + 0, Screen.width * (1 / 2) + 25, 400, 400), "\nYOU WIN!!!!!\n\n Press R to restart!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            playerwin = true;
            
            //Time.timeScale = 0f;
        }
    }
}
