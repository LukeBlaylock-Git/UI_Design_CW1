using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int CurrentScore = 0;
    public static ScoreManager Instance; //Makes ScoreManager global.
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject); //Ensures theres only one "GameManager"
    }
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    public void AddScore(int amount)
    {
        CurrentScore += amount;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        ScoreText.text = "Score: " + CurrentScore.ToString();
    }
}
