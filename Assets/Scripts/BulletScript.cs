using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody rb;
    

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = transform.position - mousePos;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;

        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot+90);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
           
            Destroy(this.gameObject);
        }
        if (collision.gameObject.layer == 7)
        {
            
            Destroy(this.gameObject);
        }
        if (collision.gameObject.layer == 10)
        {
            
            Destroy(this.gameObject);
        }
    }
}
