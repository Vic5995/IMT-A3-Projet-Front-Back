using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public string nextScene = "main_scene_v2.3 1";
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
	public void Update()
	{
		if(Input.GetKeyDown(KeyCode.A)){
			Debug.Log("A");
			Application.LoadLevel(nextScene);
		}
		if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
		{
			Debug.Log("Primary");
			this.ChangeScene(nextScene);
		}
	}
	public void Exit()
	{
		Application.Quit ();
	}
}