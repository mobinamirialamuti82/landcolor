using UnityEngine;

public class AnimationHome : MonoBehaviour
{
    public float blinkSpeed = 2f;  // سرعت چشمک زدن
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * blinkSpeed) + 1f) / 2f; // مقدار بین 0 تا 1
        Color color = spriteRenderer.color;
        color.a = alpha;
        spriteRenderer.color = color;
    }
}
