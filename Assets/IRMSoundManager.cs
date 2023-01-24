using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IRMSoundManager : MonoBehaviour
{

    private GameObject patient = null;
    private bool playerSitDown = false;

    [SerializeField] private AudioSource irmSoundEffect;

    void Start()
    {
        if (patient == null)
        {
            patient = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }

    
    void Update()
    {
        float distance = Vector3.Distance(patient.transform.position, transform.position);

        if(distance <= 4 && !irmSoundEffect.isPlaying)
        {
            irmSoundEffect.Play();
        }

        if(distance > 4 && irmSoundEffect.isPlaying)
        {
            irmSoundEffect.Pause();
        }
    }
}
