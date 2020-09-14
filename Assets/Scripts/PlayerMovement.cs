using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour {

	Animator _animator;
	private float speedModifier = 0.004f;
	public bool finished = false;

	void Start () {
		_animator = GetComponent<Animator> ();
		Application.targetFrameRate = 60;
	}

	void Update () {
		if (Input.touchCount > 0 && finished == false) {
			Touch touch = Input.GetTouch (0);
			switch (touch.phase) {
			case TouchPhase.Began:
					_animator.SetBool("isRunning", true);
					break;
			case TouchPhase.Moved:
					_animator.SetBool ("isRunning", true);
					transform.position = new Vector3(
						transform.position.x + touch.deltaPosition.x * speedModifier,
						transform.position.y,
						transform.position.z
						);
				break;

			case TouchPhase.Stationary:
				_animator.SetBool ("isRunning", true);
				break;
			case TouchPhase.Ended:
				_animator.SetBool ("isRunning", false);
				break;
			}
		}
	}
}
