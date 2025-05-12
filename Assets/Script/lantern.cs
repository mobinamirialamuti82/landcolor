using UnityEngine;

public class lantern : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;
    public GameObject character6;

    public GameObject player;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("lantern"))
        {
            other.gameObject.SetActive(false); 
            character1.SetActive(true);
            character2.SetActive(true);
            character3.SetActive(true);
            character4.SetActive(true);
            character5.SetActive(true);
            character6.SetActive(true); 
        }
    }
}
