using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChatBubble : MonoBehaviour
{
    private SpriteRenderer backgroundSpriteRenderer;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro textMeshPro;
    [SerializeField] private GameObject chatBubble;
    private void Awake()
    {
        chatBubble.SetActive(false);
        Transform backgroundTransform = transform.Find("Background");
        if (backgroundTransform != null)
        {
            backgroundSpriteRenderer = backgroundTransform.GetComponent<SpriteRenderer>();
        }

        Transform iconTransform = transform.Find("Icon");
        if (iconTransform != null)
        {
            iconSpriteRenderer = iconTransform.GetComponent<SpriteRenderer>();
        }

        Transform textTransform = transform.Find("Text");
        if (textTransform != null)
        {
            textMeshPro = textTransform.GetComponent<TextMeshPro>();
        }
    }
    private void Start() {
        chatBubble.SetActive(false);
        Setup("pikachu");
    }
    private void Setup(string text) {
        textMeshPro.SetText(text);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chatBubble.SetActive(true);
            Debug.Log("Player entered the trigger!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
       {
            chatBubble.SetActive(false);
            Debug.Log("Player exited the trigger!");
       }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in the trigger!");

        }
    }
        }
