using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletTransform;
    public bool canFire;
    public float bulletlife;
    public float timeBetweenFiring;
    public Camera mainCam;
    public GameObject bullet;
    public GameObject player;
    //private Vector3 playerPos;
    private Vector3 mousePos;
    private Vector3 midscreen;
    private float timer;
    public AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        midscreen.x = Screen.width / 2;
        midscreen.y = Screen.height / 2; 
       // playerPos = player.transform.position;
        //mainCam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();    
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = (Input.mousePosition - midscreen);
        Debug.Log(mousePos);

        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }

        if (Input.GetMouseButton(0) && canFire)
        {
            canFire = false;

            shootSound.Play();

            GameObject bullets = Instantiate(bullet, bulletTransform.position, Quaternion.identity);
            Destroy(bullets, bulletlife);
        }
    }
}
