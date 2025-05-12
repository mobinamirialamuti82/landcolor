using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioClip levelMusic;

    void Start()
    {
        if (SoundBack.Instance != null)
        {
            SoundBack.Instance.PlayMusic(levelMusic);
        }
    }
}
