using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject projectileF;
    public GameObject projectileL;
    public GameObject projectileI;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            GameObject fireball = Instantiate(projectileF, transform) as GameObject;
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * 5;
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            GameObject lightningStrike = Instantiate(projectileL, transform) as GameObject;
            Rigidbody rb2 = lightningStrike.GetComponent<Rigidbody>();
            rb2.velocity = transform.forward * 20;
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            GameObject iceSpike = Instantiate(projectileI, transform) as GameObject;
            Rigidbody rb3 = iceSpike.GetComponent<Rigidbody>();
            rb3.velocity = transform.forward * 10;
        }
    }
}
