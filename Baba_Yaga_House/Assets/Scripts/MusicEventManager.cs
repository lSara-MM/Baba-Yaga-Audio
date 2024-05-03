using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicEventManager : MonoBehaviour
{
    public AudioMixerSnapshot calmSnapshot;
    public AudioMixerSnapshot tensionSnapshot;
    //public Collider collisionForChange;

    [SerializeField] float slowTransistionTime = 4.0f;
    [SerializeField] float fastTransistionTime = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tension") 
        {
            //calmSnapshot.TransitionTo(fastTransistionTime);
            calmSnapshot.TransitionTo(slowTransistionTime);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Tension")
        {
            
            tensionSnapshot.TransitionTo(fastTransistionTime);
            //tensionSnapshot.TransitionTo(fastTransistionTime);
        }
    }
}
