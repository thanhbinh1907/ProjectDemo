using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class MaterialLerp : MonoBehaviour
{
    public Material materialA;
    public Material materialB;
    public float duration = 3.0f;
    private float currentTime = 0.0f;
    private bool isLerping = false;
    private Material origin; 
    void Start()
    {
        origin = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            isLerping = true;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            isLerping = false;
            currentTime = 0.0f;
            origin.CopyMatchingPropertiesFromMaterial(materialA);
		}
        if (isLerping)
        {
            if (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                origin.Lerp(origin, materialB, currentTime / duration);
			}
            else
            {
                isLerping = false;
            }
		}
	}
}
