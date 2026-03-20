using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    public AudioClip zombieSound;
    public float interval = 10f; // standaard 10 seconden

    private AudioSource audioSource;
    private float timer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        timer = interval;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            audioSource.PlayOneShot(zombieSound);
            timer = interval; // reset naar 10 sec
        }
    }
}