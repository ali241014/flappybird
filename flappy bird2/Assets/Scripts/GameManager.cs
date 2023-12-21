using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;

    private void Awwake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        Time.timescale = 1f;
    }
    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(Scene.Manager.GetActiveScene().buildIndex);
    }
}
