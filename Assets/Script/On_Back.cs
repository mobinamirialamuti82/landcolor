using UnityEngine;

public class On_Back : MonoBehaviour
{
    public SpriteRenderer background;       // اسپرایت پس‌زمینه
    public SpriteRenderer tree;
    public SpriteRenderer tree2;
    public float fadeSpeed = 2f;            // سرعت تغییر شفافیت

    private float startAlpha = 60f / 255f; // آلفای اولیه
    private float targetAlpha = 1f;         // آلفای نهایی (کاملاً نمایان)
    private bool shouldFade = false;

    void Start()
    {
        if (background != null)
        {
            Color color = background.color;
            color.a = startAlpha;
            background.color = color;
        }
         if (tree != null)
        {
            Color color = tree.color;
            color.a = startAlpha;
            tree.color = color;
        }
         if (tree2 != null)
        {
            Color color = tree2.color;
            color.a = startAlpha;
            tree2.color = color;
        }

    }

    void Update()
    {
        if (shouldFade && background != null)
        {
            Color currentColor = background.color;
            float newAlpha = Mathf.Lerp(currentColor.a, targetAlpha, Time.deltaTime * fadeSpeed);
            background.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);
        }

        if (shouldFade && tree != null)
        {
            Color currentColor = tree.color;
            float newAlpha = Mathf.Lerp(currentColor.a, targetAlpha, Time.deltaTime * fadeSpeed);
            tree.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);
        }

        if (shouldFade && tree2 != null)
        {
            Color currentColor = tree2.color;
            float newAlpha = Mathf.Lerp(currentColor.a, targetAlpha, Time.deltaTime * fadeSpeed);
            tree2.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Diamond"))
        {
            shouldFade = true;

            // محو کردن هدف پس از برخورد
            other.gameObject.SetActive(false);
        }
    }
}
