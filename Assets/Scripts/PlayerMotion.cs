using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    public float RunX;
    public float RunZ;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	private void OnAnimatorMove()
	{
		Animator animator = GetComponent<Animator>();
		if (animator)
		{
			Vector3 newPosition = transform.position;
			newPosition.x += RunX * Time.deltaTime;
			newPosition.z += RunZ * Time.deltaTime;
			transform.position = newPosition;
		}
	}
}
