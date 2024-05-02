using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSound : MonoBehaviour
{
    public GameObject fx = null;

    [SerializeField]
    private bool doOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        fx.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.E) || doOnce)
        {
            Debug.Log(fx.name);
            fx.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (doOnce)
        {
            fx.SetActive(false);
        }
    }
}
