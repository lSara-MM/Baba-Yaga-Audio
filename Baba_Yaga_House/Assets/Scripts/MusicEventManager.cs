using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicEventManager : MonoBehaviour
{
    public AudioMixerSnapshot calmSnapshot;
    public AudioMixerSnapshot tensionSnapshot;
    //public Collider collisionForChange;

    [SerializeField] float slowTransistionTime = 2.0f;
    [SerializeField] float fastTransistionTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dock") 
        {
            calmSnapshot.TransitionTo(fastTransistionTime);
            tensionSnapshot.TransitionTo(slowTransistionTime);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Dock")
        {
            calmSnapshot.TransitionTo(slowTransistionTime);
            tensionSnapshot.TransitionTo(fastTransistionTime);
        }
    }
}
