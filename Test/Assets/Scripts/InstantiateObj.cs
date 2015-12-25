using UnityEngine;
using System.Collections;
using Parse;
using System.Threading.Tasks;

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
	private bool A{ get; set;}
	private bool B{ get; set;}
	private bool X{ get; set;}
	private bool Y{ get; set;}
	private GameState _gameState;

	private string s1 = "Version1";
	private string s2 = "Version2";
	private string s3 = "Version3";

	private enum GameState
	{
		First,
		Second,
	}

	public void Start(){
		GoToState (GameState.First);
		StartCoroutine(Example());
		}

	public IEnumerator Example() {
		yield return new WaitForSeconds(1);
		GoToState (GameState.Second);
	}

	private void GoToState(GameState state)
	{
		switch (state) {

		case GameState.First:
			Queri ();
			break;

		case GameState.Second:
			
			Ins (A, B, X, Y);
			break;
		}
	}

	public void Queri(){
		if (ParseScr.s1 == s1) {
			ParseQuery<ParseObject> queri = ParseObject.GetQuery (ParseScr.s1);
			queri.GetAsync ("AAnuURQ4iz").ContinueWith (t => {
				ParseObject versiun1 = t.Result;
				A = versiun1.Get<bool> ("visibilityA");
				B = versiun1.Get<bool> ("visibilityB");
				X = versiun1.Get<bool> ("visibilityX");
				Y = versiun1.Get<bool> ("visibilityY");

			} 
			);
		} else if (ParseScr.s2 == s2) {
			ParseQuery<ParseObject> queri2 = ParseObject.GetQuery (ParseScr.s2);
			queri2.GetAsync ("R24mG8jWzC").ContinueWith (t => {
				ParseObject versiun2 = t.Result;
				A = versiun2.Get<bool> ("visibilityA");
				B = versiun2.Get<bool> ("visibilityB");
				X = versiun2.Get<bool> ("visibilityX");
				Y = versiun2.Get<bool> ("visibilityY");
			} 
			);
		} else if (ParseScr.s3 == s3) {
			ParseQuery<ParseObject> queri3 = ParseObject.GetQuery (ParseScr.s3);
			queri3.GetAsync ("eG8l6OY2q1").ContinueWith (t => {
				ParseObject versiun3 = t.Result;
				A = versiun3.Get<bool> ("visibilityA");
				B = versiun3.Get<bool> ("visibilityB");
				X = versiun3.Get<bool> ("visibilityX");
				Y = versiun3.Get<bool> ("visibilityY");
			} 
			);
		}

	}
	public void Ins ( bool visA, bool visB, bool visX, bool visY) {
		if (visA) {
			Instantiate (box1, new Vector3 (-6, 3, 0), Quaternion.identity);
			GameObject a = Instantiate(input1) as GameObject;
			a.transform.SetParent(canvas.transform, false);
		}
		if (visB) {
			Instantiate (box2, new Vector3 (-6, 1, 0), Quaternion.identity);
			GameObject b = Instantiate(input2) as GameObject;
			b.transform.SetParent(canvas.transform, false);
		}
		if (visX) {
			Instantiate (box3, new Vector3 (-6, -1, 0), Quaternion.identity);
			GameObject x = Instantiate(input3) as GameObject;
			x.transform.SetParent(canvas.transform, false);
		}
		if (visY) {
			Instantiate (box4, new Vector3 (-6, -3, 0), Quaternion.identity);
			GameObject y = Instantiate(input4) as GameObject;
			y.transform.SetParent(canvas.transform, false);
		}
	}
}
