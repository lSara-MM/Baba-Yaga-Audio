using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] currentAudios;
    public AudioClip[] dockAudios;
    public AudioClip[] grassAudios;
    public AudioClip[] indoorAudios;

    public float cooldown = 2.0f;
    private float _timer = 0;
    private Rigidbody _rigidbody;
    private AudioSource source;

    void Awake()
    {
        // Get the rigidbody on this.
        _rigidbody = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    void PlayAudioRandom()
    {
        source.volume = Random.Range(0.9f, 1.0f);
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(currentAudios[Random.Range(0, currentAudios.Length)]);
    }

    void AudioTimer()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0)
        {
            if (_timer >= cooldown)
            {
                PlayAudioRandom();
                _timer = 0;
            }

            else
            {
                _timer += Time.deltaTime;
            }
        }

        else
        {
            source.Stop();
            _timer = 0;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        switch (collision.gameObject.tag)
        {
            case "Dock":
                {
                    Debug.Log("Dock");
                    currentAudios = dockAudios;
                    AudioTimer();
                    break;
                }
            case "Grass":
                {
                    Debug.Log("Grass");
                    currentAudios = grassAudios;
                    AudioTimer();
                    break;
                }
            case "Indoor":
                {
                    Debug.Log("Indoor");
                    currentAudios = indoorAudios;
                    AudioTimer();
                    break;
                }
            default:
                {
                    break;
                }
        }

    }
}
