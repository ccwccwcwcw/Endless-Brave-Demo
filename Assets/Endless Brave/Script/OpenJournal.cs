using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJournal : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Journal;
    public GameObject Option;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IndexFinger"))
        {
            Inventory.SetActive(false);
            Journal.SetActive(true);
            Option.SetActive(false);
        }
    }
}