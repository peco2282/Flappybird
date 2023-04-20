using System;
using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpPower;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
