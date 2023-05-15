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



        }
