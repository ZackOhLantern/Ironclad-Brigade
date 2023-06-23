using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UI;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    //private GameObject self;
    private Health curHP;
    private int HP;
    // Start is called before the first frame update
    void Start()
    {
        //self = GetComponent<GameObject>();
        curHP = GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        HP = curHP.HP;
    }

    private void OnGUI()
    {

        GUI.Box(new Rect(Screen.width / 2 -50, Screen.height / 2 - 100, 100, 25), "HEALTH: " + HP.ToString());
    }
}
