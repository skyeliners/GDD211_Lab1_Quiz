using UnityEngine;

/// <summary>
/// Add an Animation Event to Puppy 3's IdleEvents animation.
/// This is the type of animation seen in the Lab 1 project folder: "2. 3D Animation".
/// </summary>

public class AnimationEvent : MonoBehaviour
{
	[SerializeField] private Animator puppy3Animator;
	[SerializeField] private ParticleSystem magicSpellParticleSystem;

	private void Update()
	{
		if (Input.GetAxisRaw("Vertical") > 0f)
		{
			puppy3Animator.SetBool("Move", true);
			transform.position += new Vector3(Time.deltaTime * 0.3f, 0f);
		}
		else
		{
			puppy3Animator.SetBool("Move", false);
		}
	}

	public void PuppyMagicSpell()
	{
		magicSpellParticleSystem.Emit(200);
	}
}
