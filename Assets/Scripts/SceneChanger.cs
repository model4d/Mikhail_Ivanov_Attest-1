using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class SceneChanger : MonoBehaviour
{
	public TextMeshProUGUI levelNumber;
	private int level;

	public void ChangeScene(int sceneId)
	{
		SceneManager.LoadScene(sceneId);
		Controls.curLevel = sceneId;
		level = sceneId + 1;
		levelNumber.text = "Level: " + level;

	}

	public void Exit()
	{
		Application.Quit();
	}
}
