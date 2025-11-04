using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private Animator animator;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool isWalking = (x!=0 || z!=0);
        animator.SetBool("isWalking", isWalking);
	}
}
