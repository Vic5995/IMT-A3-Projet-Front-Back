using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IRMSoundManager : MonoBehaviour
{

    private GameObject patient = null;
    private bool playerSitDown = false;


    [SerializeField] private AudioSource irmSoundEffect;
    [SerializeField] private AudioSource compresseurSoundEffect;

    void Start()
    {

        
        compresseurSoundEffect.Stop();


        if (patient == null)
        {
            patient = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }

    
    void Update()
    {   
        float distance = Vector3.Distance(patient.transform.position, transform.position);
        
        if(distance <= 40 && !irmSoundEffect.isPlaying)
        {
            irmSoundEffect.Play();
        }

        if(distance > 40 && irmSoundEffect.isPlaying)
        {
            irmSoundEffect.Pause();
        }
        if (distance <= 40 && !compresseurSoundEffect.isPlaying)
        {
            compresseurSoundEffect.Play();
        }

        if (distance > 40 && compresseurSoundEffect.isPlaying)
        {
            compresseurSoundEffect.Pause();
        }
    }
}
