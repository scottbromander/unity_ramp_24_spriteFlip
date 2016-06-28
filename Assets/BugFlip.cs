using UnityEngine;
using System.Collections;

public class BugFlip : MonoBehaviour {
	private bool facingRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow) && facingRight) {
			Flip ();
		} 
		if (Input.GetKeyDown (KeyCode.RightArrow) && !facingRight) {
			Flip ();
		}
	}

	void Flip(){
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
