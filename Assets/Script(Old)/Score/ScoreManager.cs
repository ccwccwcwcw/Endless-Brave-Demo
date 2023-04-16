using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI fscoreText;

    int score = 0;

    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Score : " + score.ToString();
    }
    public void Add1Point()
    {
        score += 1;
        scoreText.text = "Score : " + score.ToString();
        fscoreText.text = "Final Score : " + score.ToString();
    }
    public void Add2Point()
    {
        score += 2;
        scoreText.text = "Score : " + score.ToString();
        fscoreText.text = "Final Score : " + score.ToString();
    }
    public void Add3Point()
    {
        score += 3;
        scoreText.text = "Score : " + score.ToString();
        fscoreText.text = "Final Score : " + score.ToString();
    }
}
