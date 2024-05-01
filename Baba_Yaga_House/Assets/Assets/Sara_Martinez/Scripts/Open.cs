using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    Animator _animator;

    [SerializeField]
    private bool doOnce = true;

    [SerializeField]
    private bool isTrigger = false;

    private bool hasEntered = false;

    public GameObject fx;
    public GameObject fx2;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();

        if (fx != null)
        {
            fx.SetActive(false);
        }
        if (fx2 != null)
        {
            fx2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasEntered)
        {
            if (Input.GetKey(KeyCode.E) && doOnce)
            {
                Debug.Log("EEEEEEEEEEEE");

                if (_animator != null)
                { _animator.SetBool("Interacted", true); }

                if (fx != null)
                {
                    fx.SetActive(true);
                }
                if (fx2 != null)
                {
                    fx2.SetActive(true);
                }
            }
            else if (Input.GetKey(KeyCode.E) && !doOnce)
            {
                if (_animator != null)
                { _animator.SetBool("Interacted", _animator.GetBool("Interacted")); }

                if (fx != null)
                {
                    fx.SetActive(!fx.activeSelf);
                }
                if (fx2 != null)
                {
                    fx2.SetActive(!fx2.activeSelf);
                }
            }
            else if (isTrigger)
            {
                Debug.Log("Trigerrrrrr");

                if (_animator != null)
                { _animator.SetBool("Interacted", true); }

                if (fx != null)
                {
                    fx.SetActive(true);
                }
                if (fx2 != null)
                {
                    fx2.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerStay(Collider player)
    {
        hasEntered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hasEntered = false;

        if (!doOnce)
        {
            if (_animator != null)
            { _animator.SetBool("Interacted", false); }

            if (fx != null)
            {
                fx.SetActive(false);
            }
            if (fx2 != null)
            {
                fx2.SetActive(false);
            }
        }
    }
}
