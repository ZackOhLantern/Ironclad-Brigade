using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScreen : MonoBehaviour
{
    private bool pressH;
    private bool pressP;
    // Start is called before the first frame update
    void Start()
    {
        pressH = true;
        pressP = false;
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyDown(KeyCode.H))
            {
                if (pressH == true)
                    pressH = false;
                else
                {
                    pressH = true;
                }
            }

        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    if (pressP == false)
        //    {

        //        pressP = true;
        //    }
        //    else
        //    {
        //        pressH = false;

        //    }

        //}

    }

    //private void FixedUpdate()
    //{


    //    if (pressP == false)
    //    {
    //        Time.timeScale = 1f;
    //    }
    //    if (pressP == true)
    //    {
    //        Time.timeScale = 0f;
    //    }
    //}

    private void OnGUI()
    {

        GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 +50, 150, 25), "PRESS [H] FOR HELP");

        if (pressH == true)
        {
            GUI.Box(new Rect(Screen.width /2 - 125, Screen.height /2 +75, 250, 100), "REACH THE COIN TO THE EAST! \nA and D to move left and right!    \nSPACE to jump!   \nClick MOUSE to shoot! \n R to Reset the game! ");
        }
    }
}

