using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control : MonoBehaviour {

	private float boxScale1;
	public GameObject box1;

	public void Start(){
		boxScale1 = 0.4F;

	}

	public void InpField1(string inputNumber1)
	{
		boxScale1 = float.Parse(inputNumber1);

	}
		
	public void Update(){
		
		box1.transform.localScale = new Vector3 (boxScale1,boxScale1,0);

	}
}
