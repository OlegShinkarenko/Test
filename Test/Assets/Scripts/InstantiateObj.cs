using UnityEngine;
using System.Collections;
using Parse;

public class InstantiateObj : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public GameObject box3;
	public GameObject box4;

	public GameObject input1;
	public GameObject input2;
	public GameObject input3;
	public GameObject input4;

	public GameObject canvas;

	public void Start () {
		



			Instantiate (box1, new Vector3 (-6, 3, 0), Quaternion.identity);
			Instantiate (box2, new Vector3 (-6, 1, 0), Quaternion.identity);
			Instantiate (box3, new Vector3 (-6, -1, 0), Quaternion.identity);
			Instantiate (box4, new Vector3 (-6, -3, 0), Quaternion.identity);

		GameObject a = Instantiate(input1) as GameObject;
		a.transform.SetParent(canvas.transform, false);
		GameObject b = Instantiate(input2) as GameObject;
		b.transform.SetParent(canvas.transform, false);
		GameObject x = Instantiate(input3) as GameObject;
		x.transform.SetParent(canvas.transform, false);
		GameObject y = Instantiate(input4) as GameObject;
		y.transform.SetParent(canvas.transform, false);
	}



}
