using UnityEngine;

public class MathLerp : MonoBehaviour
{
    public float duration = 5.0f;
    private Material material;
    private Color originColor;
    private bool isFading = false;
    private float currentTime = 0.0f;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        material = GetComponent<Renderer>().material;
        originColor = material.color;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            isFading = true;
            currentTime = 0.0f;
            originColor = material.color;
            originColor.a = 1.0f;
		}
        if (Input.GetKeyDown(KeyCode.P))
        {
            isFading = false;
            material.color = originColor;
        }
        if (isFading)
        {
            if (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                float alpha = Mathf.Lerp(1.0f, 0.0f, currentTime / duration);
                Color newColor = new Color(originColor.r, originColor.g, originColor.b, alpha);
                material.color = newColor;
			}
		}
        else
        {
            isFading = false;
		}
	}
}
