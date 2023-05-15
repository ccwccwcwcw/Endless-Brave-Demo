using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOption : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Journal;
    public GameObject Option;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IndexFinger"))
        {
            Inventory.SetActive(false);
            Journal.SetActive(false);
            Option.SetActive(true);
        }
    }
}