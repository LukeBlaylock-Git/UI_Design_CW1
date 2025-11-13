using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance;
    public int CurrentScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        CurrentScore += value;
        Debug.Log("Score " + CurrentScore);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}