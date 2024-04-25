using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("")) //Si es un tipo suelo
        {
            switch (collision.gameObject.GetComponent<PhysicMaterial>().name) 
            {
                case "Wood":
                    {
                        break;
                    }
                case "Grass":
                    {
                        break;
                    }
                default: 
                    { 
                        break;
                    }
            }
        }
    }
}
