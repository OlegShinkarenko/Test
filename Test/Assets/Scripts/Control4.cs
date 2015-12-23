using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control4 : MonoBehaviour {

	private float boxScale4;
	public GameObject box4;



	void Start () {
		box4 = GameObject.Find ("Box 4(Clone)");
		boxScale4 = 0.2F;
	}

	public void InpField4()
	{
		boxScale4 = GetComponent<Scrollbar> ().value;
	}
	void Update () {
		box4.transform.localScale = new Vector3 (boxScale4,boxScale4,0);
	}
}
