using UnityEngine;

public class MoveCube : MonoBehaviour
{
	// Tốc độ xoay của cube
	public float rotationSpeed = 5;
	public float travelSpeed = 5;
	private Vector3 originalPotision = new Vector3(0, 0, 0);
	public float smooth; 
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		// Thêm vào đây code xoay cube
		//transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);
		// Code xoay cube khi nhấn phím mũi tên trái hoặc phải
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up * Time.deltaTime * travelSpeed);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.down * Time.deltaTime * travelSpeed);
		}
		/*
		else if (Input.GetKey(KeyCode.O))
		{
			transform.position = originalPotision;
		}
		*/
		else if (Input.GetKey(KeyCode.O))
		{
			transform.position = originalPotision;
		}
	}
}
