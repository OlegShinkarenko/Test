using UnityEngine;
using System.Collections;
using Parse;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ParseScr: MonoBehaviour {

 
	public string a;
	public void VersionButton1()
	{
		GameObject inputFieldGo = GameObject.Find("InputFieldId");
		InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();

	    /*var version1 = new ParseObject ("Version1");
		version1 ["userId"] = inputFieldCo.text;
		version1 ["visibilityA"] = true;
		version1 ["visibilityB"] = true;
		version1 ["visibilityX"] = false;
		version1 ["visibilityY"] = false;
		version1 ["visibilityBoxA"] = true;
		version1 ["visibilityBoxB"] = true;
		version1 ["visibilityBoxX"] = false;
		version1 ["visibilityBoxY"] = false;*/

		ParseQuery<ParseObject> queri = ParseObject.GetQuery ("Version1");
		queri.GetAsync ("833J3yyBnu").ContinueWith(t => 
			{
				ParseObject versiun1 = t.Result;
				string s = versiun1.Get<string>("userId");
				a = s;
			} 
		);
		Debug.Log (a);
		//version1.SaveAsync ();


		SceneManager.LoadScene ("Second");
	}

	/*public void VersionButton2()
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
	}*/
		

		
	

}
