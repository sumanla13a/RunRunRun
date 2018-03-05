﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour {
	private Animator animator;
	private InputState inputState;

	// Use this for initialization
	void Awake () {
		animator = GetComponent<Animator> ();
		inputState = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {
		var running = true;

		if (inputState.absVelX > 0 && inputState.absVelY < inputState.standingThershold)
			running = false;

		animator.SetBool ("Running", running);
	}
}
