using UnityEngine;

public class LerpAngle : MonoBehaviour
{

    public float targetAngle = 300.0f;
    public float duration = 2.0f;
    private bool isLerping = false;
	private float originAngle;

	private void Start()
	{
		originAngle = transform.eulerAngles.y;
	}

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.O))
		{
			isLerping = true;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			isLerping = false;
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, originAngle, transform.eulerAngles.z);
		}

		if (isLerping)
		{
			float currentAngle = transform.eulerAngles.y;
			float newAngle = Mathf.LerpAngle(currentAngle, targetAngle, duration * Time.deltaTime);
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, newAngle, transform.eulerAngles.z);
		}
	}
}
