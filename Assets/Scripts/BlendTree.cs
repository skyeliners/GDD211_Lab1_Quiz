using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed=2f;

	private void Update()
	{
		if (Input.GetAxisRaw("Vertical") > 0f) //Walk
		{
			transform.position += new Vector3(Time.deltaTime * 0.32f * speed, 0f);
			puppy2Animator.SetFloat("Blend",1);
		}
		else //Idle
		{
			puppy2Animator.SetFloat("Blend",0);
		}

	}
}
