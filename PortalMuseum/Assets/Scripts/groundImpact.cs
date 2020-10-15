using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundImpact : MonoBehaviour
{
    public AudioClip impact;
    public AudioSource soundSource;
    public Rigidbody obj;

    private void Start()
    {
        soundSource = GetComponent<AudioSource>();
        obj = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "floor" && obj.velocity.magnitude >= 0.3)
        {
           
            soundSource.PlayOneShot(impact, 0.7f);
            Debug.Log("sound played");
        }
    }
}
