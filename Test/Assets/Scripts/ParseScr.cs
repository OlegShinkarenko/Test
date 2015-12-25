using UnityEngine;
using System.Collections;
using Parse;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ParseScr: MonoBehaviour {

	public static string s1, s2, s3;

	public void VersionButton1()
	{	
		s1 = "Version1";
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();

	    var version1 = new ParseObject ("Version1");
		version1 ["userId"] = inputFieldCo.text;
		version1 ["visibilityA"] = true;
		version1 ["visibilityB"] = true;
		version1 ["visibilityX"] = false;
		version1 ["visibilityY"] = false;

		 version1.SaveAsync ();
	
		SceneManager.LoadScene ("Second");
	}

	public void VersionButton2()
	{
		s2 = "Version2";
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();

		var version2 = new ParseObject ("Version2");
		version2 ["userId"] = inputFieldCo.text;
		version2 ["visibilityA"] = true;
		version2 ["visibilityB"] = true;
		version2 ["visibilityX"] = true;
		version2 ["visibilityY"] = false;

		version2.SaveAsync ();

		SceneManager.LoadScene("Second");
	}
	public void VersionButton3()
	{
		s3 = "Version3";
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();

		var version3 = new ParseObject ("Version3");
		version3 ["userId"] = inputFieldCo.text;
		version3 ["visibilityA"] = false;
		version3 ["visibilityB"] = false;
		version3 ["visibilityX"] = true;
		version3 ["visibilityY"] = true;

		version3.SaveAsync(); 

		SceneManager.LoadScene("Second");
	}
		

		
	

}
