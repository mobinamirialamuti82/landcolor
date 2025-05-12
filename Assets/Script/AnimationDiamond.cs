using UnityEngine;

public class AnimationDiamond : MonoBehaviour
{
    [SerializeField] private float transparencyRange = 0.5f;   // میزان تغییر شفافیت
    [SerializeField] private float pulseSpeed = 2f;            // سرعت نوسان شفافیت
    [SerializeField] private float minAlpha = 0.5f;            // مقدار پایه شفافیت

    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        UpdateAlpha();
    }

    private void UpdateAlpha()
    {
        if (sr == null) return;

        float dynamicAlpha = minAlpha + Mathf.Sin(Time.time * pulseSpeed) * transparencyRange;
        dynamicAlpha = Mathf.Clamp01(dynamicAlpha);

        Color currentColor = sr.color;
        currentColor.a = dynamicAlpha;
        sr.color = currentColor;
    }
}
