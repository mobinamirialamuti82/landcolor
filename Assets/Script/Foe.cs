using UnityEngine;

public class Foe : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject player;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.position= startPoint.transform.position;
        }
    }
}
