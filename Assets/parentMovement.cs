﻿using UnityEngine;
using System.Collections;

public class parentMovement : StateMachineBehaviour {

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	/*override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.transform.parent.position = animator.gameObject.transform.position;
        animator.gameObject.transform.localPosition = Vector3.zero;
    }*/

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.transform.parent.position = new Vector3(animator.gameObject.transform.parent.position.x, animator.gameObject.transform.parent.position.y, animator.gameObject.transform.parent.position.z+2);
        animator.gameObject.transform.localPosition = Vector3.zero;
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	/*override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.transform.parent.position = animator.gameObject.transform.position;
        animator.gameObject.transform.localPosition = Vector3.zero;
    }*/

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
