using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    
    public void RestartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
