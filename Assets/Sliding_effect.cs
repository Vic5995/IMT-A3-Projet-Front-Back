using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sliding_effect : MonoBehaviour
{
    public Transform destination;
    public float moveSpeed = 20f;
    private float cpt;

    private bool manualPause = false;

    private GameObject patient = null;
    private bool playerSitDown = false;

    [SerializeField] private AudioSource irmSoundEffect;
    [SerializeField] private AudioSource compresseurSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        GameObject IRM_Pipe = GameObject.Find("IRM_pipe");
        destination = IRM_Pipe.transform;
        // destination.position = new Vector3(destination.position.x - 1, destination.position.y, destination.position.z);
        transform.position = new Vector3(6f, 0f, 6.69f);

        cpt = Math.Abs(Vector3.Distance(transform.position, destination.position)) + 1.5f;

        compresseurSoundEffect.Stop();
        irmSoundEffect.Stop();

        if (patient == null)
        {
            patient = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }

    // Update is called once per frame
    void Update()
    {
        var step = Time.deltaTime * moveSpeed;
        //if (Vector3.Distance(transform.position, destination.position) >= 0.1f)
        if (cpt > 0)
        {
            //transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
            transform.Translate(0, 0, -step);
            cpt -= step;
        }
        if (Math.Abs(transform.position.x - destination.position.x) > 1.5f)
        {
            if (!irmSoundEffect.isPlaying && !manualPause)
            {
                irmSoundEffect.Play();
            }
            if (!compresseurSoundEffect.isPlaying) 
            {
                compresseurSoundEffect.Play();
            }
        }

        if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            Debug.Log("XRI_Right_PrimaryButton");
            if (irmSoundEffect.isPlaying && !manualPause)
            {
                irmSoundEffect.Pause();
                manualPause = true;
            }
            if(manualPause)
            {
                SceneManager.LoadScene("MRI_preparation_scene");
            }
        }
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            if (!irmSoundEffect.isPlaying)
            {
                irmSoundEffect.Play();
            }
            else
            {
                SceneManager.LoadScene("MRI_preparation_scene");
            }
        }
    }
}
