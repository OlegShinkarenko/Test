using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control2 : MonoBehaviour {

	private float boxScale2;
	public GameObject box2;


	public void Start(){
		box2 = GameObject.Find ("Box 2(Clone)");
		boxScale2 = 0.3F;
	}
		
	public void InpField2(string inputNumber)
	{
		boxScale2 = float.Parse(inputNumber);
	}

	public void Update(){

		box2.transform.localScale = new Vector3 (boxScale2,boxScale2,0);
	}
}
