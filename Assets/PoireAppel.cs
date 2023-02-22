/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PoireAppel : MonoBehaviour
{
    private bool isSoundStopped = false;
    // GameObject IRM = GameObject.Find("IRM_Body");
    private IRMSoundManager irmSoundManager;
    // Start is called before the first frame update
    void Start()
    {
        // irmSoundManager = IRM.GetComponent<IRMSoundManager>();
    }

    // Update is called once per frame
    
    private void Update()
    {
        if (Input.GetButtonDown("XRI_Right_GripButton"))
        {
            Debug.Log("XRI_Right_GripButton");
            if (isSoundStopped == false)
            {
                irmSoundManager.GetIrmSoundEffect().Pause();
                irmSoundManager.GetCompresseurSoundEffect().Pause();
                isSoundStopped = true;
            }
            else
            {
                SceneManager.LoadScene("MRI_preparation_scene");
            }
        }
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            Debug.Log("XRI_Left_PrimaryButton");
            if (isSoundStopped == true)
            {
                irmSoundManager.GetIrmSoundEffect().Pause();
                irmSoundManager.GetCompresseurSoundEffect().Pause();
                isSoundStopped = false;
            }
            else
            {
                SceneManager.LoadScene("MRI_preparation_scene");
            }
        }
    }
}
*/