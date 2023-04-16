
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public GameObject gameOverPanel;
    public GameObject YouWinPanel;
    bool gameOver = false;
    bool youWin = false;

    public void GameOver()
    {
        if (gameOver == false)
        {
            gameOver = true;
            GameObject varGameObject = GameObject.FindWithTag("Player");
            GameObject varGameObject2 = GameObject.FindWithTag("Enemy");
            varGameObject.GetComponent<PlayerHealth>().enabled = false;
            varGameObject.GetComponent<PlayerMagicInput>().enabled = false;
            varGameObject2.GetComponent<EnemyHealth>().enabled = false;
            varGameObject2.GetComponent<PathFinding>().enabled = false;
            gameOverPanel.gameObject.SetActive(true);
        }
    }
    public void YouWin()
    {
        if (youWin = false)
        {
            youWin = true;
            GameObject varGameObject = GameObject.FindWithTag("Player");
            GameObject varGameObject2 = GameObject.FindWithTag("Enemy");
            varGameObject.GetComponent<PlayerHealth>().enabled = false;
            varGameObject.GetComponent<PlayerMagicInput>().enabled = false;
            varGameObject2.GetComponent<EnemyHealth>().enabled = false;
            varGameObject2.GetComponent<PathFinding>().enabled = false;
            YouWinPanel.gameObject.SetActive(true);
        }
    }

}
