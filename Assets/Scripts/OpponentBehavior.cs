using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.name =="Player")
        {
            //
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {

        }
    }
}
