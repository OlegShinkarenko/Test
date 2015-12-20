using UnityEngine;
using System.Collections;
using Parse;
using UnityEngine.SceneManagement;

public class ParseScr: MonoBehaviour {

	private string userId;
	private string f;

	public void InpField2(string inputNumber)
	{
		userId = inputNumber;

	}

	public void Update (){
		Debug.Log(userId);
	}


	public void VersionButton1()
	{
		var version1 = new ParseObject ("Version1");
		version1 ["userId"] = 7;
		version1.SaveAsync().ContinueWith(t=> {Debug.Log("Finished! ");});

		//SceneManager.LoadScene("Second");
	}
		

		
	

}
