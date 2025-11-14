using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int CoinValue = 1;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(CoinValue);
            Destroy(gameObject);
        }
    }
}
