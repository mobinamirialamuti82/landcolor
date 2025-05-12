using UnityEngine;

public class AnimationFoe: MonoBehaviour
{
    [SerializeField] private float moveRange = 0.5f;     // محدوده بالا و پایین رفتن
    [SerializeField] private float moveSpeed = 1.0f;     // سرعت نوسان

    private Vector3 initialPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        ApplyVerticalOscillation();
    }

    private void ApplyVerticalOscillation()
    {
        float offsetY = Mathf.Sin(Time.time * moveSpeed) * moveRange;
        Vector3 newPosition = initialPosition;
        newPosition.y += offsetY;
        transform.position = newPosition;
    }
}
