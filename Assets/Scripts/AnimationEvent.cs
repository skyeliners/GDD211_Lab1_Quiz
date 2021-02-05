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

	}

	public void PuppyMagicSpell()
	{
		magicSpellParticleSystem.Emit(200);
	}
}
