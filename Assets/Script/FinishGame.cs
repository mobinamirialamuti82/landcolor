using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject endCanvas; // اشاره به UI Canvas

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            endCanvas.SetActive(true); // Canvas رو فعال کن
        }
    }
}
