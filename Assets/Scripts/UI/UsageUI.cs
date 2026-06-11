using UnityEngine;
using UnityEngine.UI;

public class UsageUI : MonoBehaviour
{
    public static UsageUI instance;

    public RawImage rawImage;
    private void Awake()
    {
        instance = this;
        rawImage = GetComponentInChildren<RawImage>();
        rawImage.enabled = false;
    }

    public void ShowRawImage() 
    {
        rawImage.enabled = true;
    }

    public void HideRawImage()
    {
        rawImage.enabled = false;
    }
}
