using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour {

    public float myTimer = 5;

    TextMeshProUGUI text;

    void Start() {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
            text.text = "Time: " + Mathf.Ceil(myTimer).ToString();
        }

        else
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}