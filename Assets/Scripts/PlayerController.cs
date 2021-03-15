using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
   public Joystick joystick;
   public CharacterController controller;

   private Animator _animator;

   private bool _weapon;
   private bool _pistol;
   
   public float speed;
   public float gravity;
  
   
   Vector3 moveDirection;

   private void Start()
   {
	   _animator = gameObject.GetComponent<Animator>();
   }

   void Update(){
	  
	   
	   Vector2 direction = joystick.direction;

	   
	   
	   if(controller.isGrounded)
	   {
            moveDirection = new Vector3(direction.x, 0, direction.y);
			
			Quaternion targetRotation = moveDirection != Vector3.zero ? Quaternion.LookRotation(moveDirection) : transform.rotation;
			transform.rotation = targetRotation;
		    moveDirection = moveDirection * speed;
	   }

	   moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
	   controller.Move(moveDirection * Time.deltaTime);
	   
	   if (direction != Vector2.zero)
	   {
	       
		   _animator.SetInteger("State", 1);
	   }
	   else
	   {
		   _animator.SetInteger("State", 0);
	   }

	   
	   
	   if (Input.GetKeyDown(KeyCode.R))
	   {
		   _weapon = ! _weapon;
		   _animator.SetBool("isWeapon", _weapon);
	   }
	   
		if (Input.GetKeyDown(KeyCode.P))
	   {
		   _pistol = ! _pistol;
		   _animator.SetBool("isPistol", _pistol);
	   }
		
   }
   
   
   
   
   
   
}
