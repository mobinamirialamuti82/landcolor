using UnityEngine;

public class AnimationFoeLevel2 : MonoBehaviour
{
    public Transform pointA;   // نقطه شروع حرکت
    public Transform pointB;   // نقطه پایان حرکت
    public float speed = 2f;   // سرعت حرکت دشمن

    private Vector3 target;

    void Start()
    {
        target = pointB.position;
    }

    void Update()
    {
        // حرکت دشمن فقط در محور X (برای طبیعی بودن حرکت افقی)
        Vector3 newPosition = new Vector3(
            Mathf.MoveTowards(transform.position.x, target.x, speed * Time.deltaTime),
            transform.position.y,
            transform.position.z
        );
        transform.position = newPosition;

        // اگر به نقطه هدف رسید، جهت را تغییر بده
        if (Mathf.Abs(transform.position.x - target.x) < 0.1f)
        {
            target = (target == pointA.position) ? pointB.position : pointA.position;
        }

        // چرخش به سمت مسیر حرکت (اختیاری)
        Vector3 scale = transform.localScale;
        scale.x = target.x < transform.position.x ? Mathf.Abs(scale.x) : -Mathf.Abs(scale.x);
        transform.localScale = scale;
    }
}
