using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control3 : MonoBehaviour {

	private float boxScale3;
	public GameObject box3;

	void Start () {
		boxScale3 = 0.2F;
	}

	public void InpField3()
	{
		boxScale3 = GetComponent<Scrollbar> ().value;
	}
	void Update () {
		box3.transform.localScale = new Vector3 (boxScale3,boxScale3,0);
	}
}
