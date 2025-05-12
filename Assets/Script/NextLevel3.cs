using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D Other)
    {
        if(Other.gameObject.tag=="Player")
        {
            SceneManager.LoadScene("Level3");
        }
        
    }
}
