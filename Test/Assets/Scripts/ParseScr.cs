using UnityEngine;
using System.Collections;
using Parse;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ParseScr: MonoBehaviour {

	public void VersionButton1()
	{
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
	
	    var version1 = new ParseObject ("Version1");
		version1 ["userId"] = inputFieldCo.text;
		version1.SaveAsync(); 

		//SceneManager.LoadScene("Second");
	}
	public void VersionButton2()
	{
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();

		var version2 = new ParseObject ("Version2");
		version2 ["userId"] = inputFieldCo.text;
		version2.SaveAsync(); 

		//SceneManager.LoadScene("Second");
	}
	public void VersionButton3()
	{
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();

		var version3 = new ParseObject ("Version3");
		version3 ["userId"] = inputFieldCo.text;
		version3.SaveAsync(); 

		//SceneManager.LoadScene("Second");
	}
		

		
	

}
