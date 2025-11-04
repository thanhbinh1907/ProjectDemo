using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    public Color colorA = Color.red;
    public float duration = 5.0f;
    private Color originColor;
    private Material material;
    private float currentTime = 0f;
    bool isLerping = false;
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
            isLerping = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            isLerping = false;
            currentTime = 0f;
            material.color = originColor;
		}
        if (isLerping)
        {
            if (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                material.color = Color.Lerp(originColor, colorA, currentTime / duration);
            }
        }
    }
}