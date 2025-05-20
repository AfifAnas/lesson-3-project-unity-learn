using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (restartButton != null)
            restartButton.onClick.AddListener(ResetTheGame);
    }

    public void ShowPanel()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }

    public void HidePanel()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
