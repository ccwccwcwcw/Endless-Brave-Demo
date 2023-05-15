using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Journal;
    public GameObject Option;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IndexFinger"))
        {
            Inventory.SetActive(true);
            Journal.SetActive(false);
            Option.SetActive(false);
        }
    }
}