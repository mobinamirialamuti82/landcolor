using UnityEngine;

public class BoxOnFoe : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // اگر به دشمن برخورد کرد
        if (collision.collider.CompareTag("Foe"))
        {
            // دشمن را حذف کن
            Destroy(collision.collider.gameObject);
        }
    }
}
