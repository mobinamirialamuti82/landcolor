using UnityEngine;

public class On_BackLevel2 : MonoBehaviour
{
    public SpriteRenderer background;       // اسپرایت پس‌زمینه
    public SpriteRenderer sky;
    public SpriteRenderer mount;
    public float fadeSpeed = 2f;            // سرعت تغییر شفافیت

    private float startAlpha = 70f / 255f; // آلفای اولیه
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
        if (sky != null)
        {
            Color color = sky.color;
            color.a = startAlpha;
            sky.color = color;
        }
        if (mount != null)
        {
            Color color = mount.color;
            color.a = startAlpha;
            mount.color = color;
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
         if (shouldFade && background != null)
        {
            Color currentColor = background.color;
            float newAlpha = Mathf.Lerp(currentColor.a, targetAlpha, Time.deltaTime * fadeSpeed);
            background.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);
        }
         if (shouldFade && background != null)
        {
            Color currentColor = background.color;
            float newAlpha = Mathf.Lerp(currentColor.a, targetAlpha, Time.deltaTime * fadeSpeed);
            background.color = new Color(currentColor.r, currentColor.g, currentColor.b, newAlpha);
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
