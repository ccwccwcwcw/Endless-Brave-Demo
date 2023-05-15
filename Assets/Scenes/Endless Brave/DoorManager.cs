using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    public string Lab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Lab);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(Lab));
            GameObject targetPosition = GameObject.Find("TargetPosition");
            PlayerData.playerPosition = targetPosition.transform.position;
            PlayerData.playerRotation = targetPosition.transform.rotation;
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = PlayerData.playerPosition;
            player.transform.rotation = PlayerData.playerRotation;
        }
    }
}
