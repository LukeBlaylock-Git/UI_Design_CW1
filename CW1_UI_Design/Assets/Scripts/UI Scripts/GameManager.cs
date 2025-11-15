using UnityEngine;
using TMPro;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public float RemainingTime = 300f;
    private bool isGameRunning = true; //If the game is paused or we run out of time, we'll use this to prevent issues and actuall drain the timer.
    public TMP_Text TimerText;
    public GameObject GameOverPanel;
    public PlayerController player; //setting a reference to the PlayerController
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int minutes = Mathf.FloorToInt(RemainingTime / 60);
        int seconds = Mathf.FloorToInt(RemainingTime % 60);
        TimerText.text = $"{minutes:00}:{seconds:00}"; //our actual display seperated into minutes and seconds, better visuals.
        if (!isGameRunning)
            return;

        RemainingTime -= Time.deltaTime;

        if (RemainingTime <= 0)
        {
            RemainingTime = 0;
            GameOver();
        }
    }
    public void GameOver()
    {
        isGameRunning = false;
        Time.timeScale = 0f; //pauses the game
        Debug.Log("Game over function called.");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        GameOverPanel.SetActive(true); //Making the game over panel visible.
    }
    public void Restart()
    {
        Time.timeScale = 1f; //unpauses the game
    }
}
