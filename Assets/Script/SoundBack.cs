using UnityEngine;
using System.Collections;

public class SoundBack : MonoBehaviour
{
    public static SoundBack Instance;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip defaultMusic;
    [SerializeField] private float fadeDuration = 1.5f;

    void Awake()
    {
        // Singleton: فقط یکی از این شیء وجود داشته باشه
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.volume = 0.15f;

        if (defaultMusic != null)
        {
            PlayMusic(defaultMusic);
        }
    }

    public void PlayMusic(AudioClip newClip)
    {
        if (audioSource.clip == newClip) return;

        StopAllCoroutines();
        StartCoroutine(FadeMusic(newClip));
    }

    private IEnumerator FadeMusic(AudioClip newClip)
    {
        // Fade out
        float startVolume = audioSource.volume;
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            audioSource.volume = Mathf.Lerp(startVolume, 0, t / fadeDuration);
            yield return null;
        }

        audioSource.Stop();
        audioSource.clip = newClip;
        audioSource.Play();

        // Fade in
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            audioSource.volume = Mathf.Lerp(0, startVolume, t / fadeDuration);
            yield return null;
        }

        audioSource.volume = startVolume;
    }
}
