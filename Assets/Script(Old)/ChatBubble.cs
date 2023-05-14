using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChatBubble : MonoBehaviour
{
    private SpriteRenderer backgroundSpriteRenderer;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro textMeshPro;

    private void Awake() {
        backgroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        iconSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        textMeshPro =transform.Find("Text").GetComponent<TextMeshPro>();
    }
    private void Start() {
        Setup("pikachu");
    }
    private void Setup(string text) {
        textMeshPro.SetText(text);
    }
}
