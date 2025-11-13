using UnityEngine;

public class coin_script : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Game_Manager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}

