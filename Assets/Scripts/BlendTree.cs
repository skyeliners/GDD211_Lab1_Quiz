using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed;

	private void Update()
	{
		if(Input.GetAxisRaw("Vertical") > 0f)
		{
			speed = Mathf.Lerp(speed, 1f, Time.deltaTime * 2f);
		}
		else
		{
			speed = Mathf.Lerp(speed, 0f, Time.deltaTime * 10f);
		}
		puppy2Animator.SetFloat("Move", speed);
		transform.position += new Vector3(Time.deltaTime * 0.3f * speed, 0f);
	}
}
