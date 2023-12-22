using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    [SerializeField] private GameObject _gameOverCanvas;
    // Start is called before the first frame update
    private void Awake ()
    {
        if ( Instance == null)
        {
            Instance = this;
        }

        Time.timeScale = 1f;
    }

    // Update is called once per frame
   public  void GameOver()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
