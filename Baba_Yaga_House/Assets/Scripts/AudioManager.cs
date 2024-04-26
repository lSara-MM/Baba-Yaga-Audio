using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] currentAudios;
    public AudioClip[] dockAudios;
    public AudioClip[] grassAudios;
    public AudioClip[] indoorAudios;

    void PlayAudioRandom()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.volume = Random.Range(0.9f, 1.0f);
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(currentAudios[Random.Range(0, currentAudios.Length)]);
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
                    break;
                }
            case "Grass":
                {
                    Debug.Log("Grass");
                    currentAudios = grassAudios;
                    break;
                }
            case "Indoor":
                {
                    Debug.Log("Indoor");
                    currentAudios = indoorAudios;
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}
