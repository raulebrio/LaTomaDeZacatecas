﻿using UnityEngine;
using System.Collections;

public class disparoWinchester : StateMachineBehaviour {
	//private int casquillos;
	private disparosDelJugador disparo;
	//public GameObject flash;
	Animator anim;
	//	private AnotherScript anotherScript;
	//private GameObject otherScript;
	//OtherScript = GetComponent(OtherScript);
	//public GameObject objectToAccess;
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		//Instantiate(flash,);
//		casquillos = animator.GetInteger ("casquillos");
		
		//GameObject Object1 = GameObject.Find ("armas");
		//Component anotherScript = Object1.GetComponent<disparosDelJugador> ();
		disparo = GameObject.Find ("armas").GetComponent<disparosDelJugador> ();
		disparo.disparo (.34f);
		anim = GameObject.Find ("Animacionwinchester_94_30-30").GetComponent<Animator> ();
		
		anim.SetInteger ("cartuchos",anim.GetInteger("cartuchos")-1);
		
		//		Script1.disparo ();
		
		
	}
	
	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
	
	//OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
//		animator.SetInteger ("casquillos",casquillos+1);
	}
	
	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
	
	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}