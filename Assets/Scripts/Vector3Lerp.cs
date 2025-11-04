using UnityEngine;

public class Vector3Lerp : MonoBehaviour
{
    public float smooth = 5;
    public Vector3 target = Vector3.zero;
    public Vector3 origin;
    private bool isLerping = false;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        origin = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            isLerping = true;
		}
        if (Input.GetKeyDown(KeyCode.P))
        {
            isLerping = false;
            transform.position = origin;
        }
        if (isLerping)
			transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * smooth);
	}
}
