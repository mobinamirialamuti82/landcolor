using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;           // آبجکت هدف (مثلاً کاراکتر)
    public float smoothSpeed = 0.1f;   // مقدار نرمی حرکت دوربین

    private float initialY;            // مقدار اولیه محور Y
    private float initialZ;            // مقدار اولیه محور Z

    void Start()
    {
        // ذخیره Y و Z اولیه دوربین
        initialY = transform.position.y;
        initialZ = transform.position.z;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // فقط محور X را از target بگیر، Y و Z را ثابت نگه دار
        Vector3 desiredPosition = new Vector3(target.position.x, initialY, initialZ);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
