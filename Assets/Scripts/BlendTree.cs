using UnityEngine;

public class BlendTree : MonoBehaviour
{
	public Animator animator;

	void Update()
	{
		// Lấy input từ bàn phím
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		// Tính tốc độ tổng hợp (0 → 1)
		float moveSpeed = new Vector3(inputX, 0, inputZ).magnitude;

		// Tăng nhanh hoặc giảm chậm để tạo cảm giác mượt
		moveSpeed = Mathf.Lerp(animator.GetFloat("Speed"), moveSpeed * 5, Time.deltaTime);

		// Gán giá trị cho Animator
		animator.SetFloat("Speed", moveSpeed);
	}
}
