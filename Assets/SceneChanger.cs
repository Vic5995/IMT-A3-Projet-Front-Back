using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public string nextScene = "main_scene_v2.3 1";
	private Jun_TweenRuntime fadingAnimator;

    private void OnEnable()
    {
        fadingAnimator = GameObject.Find("BlackFade_Out").GetComponent<Jun_TweenRuntime>();
    }


    private void Update()
    {
        if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
        {
            FadeToLevel(this.nextScene);
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void FadeToLevel(string sceneName)
    {
        fadingAnimator.Play();
    }

}
