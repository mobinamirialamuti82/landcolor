using UnityEngine;
using System.Collections.Generic;

public class SoundPlayerLevel1 : MonoBehaviour
{
    [System.Serializable]
    public class TagSound
    {
        public string tag;
        public AudioClip sound;
    }

    [SerializeField] private List<TagSound> tagSounds;
    private AudioSource audioSource;
    private Dictionary<string, AudioClip> soundMap;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;

        // ساخت نقشه‌ی تگ ← صدا
        soundMap = new Dictionary<string, AudioClip>();
        foreach (var ts in tagSounds)
        {
            if (!soundMap.ContainsKey(ts.tag))
            {
                soundMap.Add(ts.tag, ts.sound);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlaySoundIfTagged(collision.gameObject.tag);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PlaySoundIfTagged(other.tag);
    }

    private void PlaySoundIfTagged(string tag)
    {
        if (soundMap.ContainsKey(tag))
        {
            AudioClip clip = soundMap[tag];
            if (clip != null)
            {
                audioSource.PlayOneShot(clip);
            }
        }
    }
}
