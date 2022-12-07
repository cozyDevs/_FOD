using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
	public float speed;
	public Animator PlayerAnimator;
	public bool gameOpen = false;

	void Update()
	{
		PlayerMovement();
	}

	void PlayerMovement()
	{
		if (!gameOpen)
		{
			float hor = Input.GetAxis("Horizontal");
			float ver = Input.GetAxis("Vertical");
			Vector3 playerMovement = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
			transform.Translate(playerMovement, Space.Self);

			if (Input.GetAxis("Vertical") > 0)
			{
				PlayerAnimator.ResetTrigger("Idle");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.SetTrigger("Forward");
			}
			if (Input.GetAxis("Vertical") < 0)
			{
				PlayerAnimator.ResetTrigger("Idle");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.SetTrigger("Backward");
			}
			if (Input.GetAxis("Horizontal") > 0)
			{
				PlayerAnimator.ResetTrigger("Idle");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.SetTrigger("Right");
			}
			if (Input.GetAxis("Horizontal") < 0)
			{
				PlayerAnimator.ResetTrigger("Idle");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.SetTrigger("Left");
			}
			if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
			{
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.SetTrigger("Idle");
			}
		}
	}





}

