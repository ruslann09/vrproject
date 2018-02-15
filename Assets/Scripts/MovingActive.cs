using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingActive : MonoBehaviour {
	public Animator anim, anim1;
	private WaitForSeconds timeToPlayBack1, timeToPlayBack2;

	void Start () {
		timeToPlayBack1 = new WaitForSeconds (1.0f);
		timeToPlayBack2 = new WaitForSeconds (2.0f);

		StartCoroutine (AirCondition1 ());
		StartCoroutine (AirCondition2 ());
	}

	private IEnumerator AirCondition1 () {
		yield return timeToPlayBack1;
		anim.SetTrigger ("Start");
	}

	private IEnumerator AirCondition2 () {
		yield return timeToPlayBack2;
		anim1.SetTrigger ("Start");
	}
}
