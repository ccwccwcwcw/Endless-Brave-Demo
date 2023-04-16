using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    private GameObject BulletObject;
    public GameObject SpawnPoint;
    public AudioSource aSource;
    public AudioClip aClip;
    public float pushForce;

    public float shootTimer = 0.1f;

    private float recoilAngle = 30f;
    private float recoilTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(ShootBullet());

            StartCoroutine(RecoilGun());

        }


    }

    IEnumerator ShootBullet()
    {
        BulletObject = Instantiate(BulletPrefab, SpawnPoint.transform.position, SpawnPoint.transform.rotation) as GameObject;

        BulletObject.GetComponent<Rigidbody>().AddForce(GameObject.Find("glovers").transform.forward * pushForce);

        aSource.PlayOneShot(aClip);

        yield return new WaitForSeconds(shootTimer);

    }

    IEnumerator RecoilGun()
    {
        GameObject.Find("glovers").transform.Rotate(-recoilAngle, 0, 0, Space.Self);

        yield return new WaitForSeconds(recoilTime);

        GameObject.Find("glovers").transform.Rotate(recoilAngle, 0, 0, Space.Self);

    }


}