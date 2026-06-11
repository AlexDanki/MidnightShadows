using UnityEngine;

public class UsableAction : MonoBehaviour
{
    private GameObject usageUi;

    bool isUsing = false;

    private void Awake()
    {
        
    }

    private void Start()
    {
    }

    public void ShowUsableUi() 
    {
        if (!isUsing) 
        {
            UsageUI.instance.ShowRawImage();
            isUsing = true;
        }
        else 
        {
            UsageUI.instance.HideRawImage();
            isUsing = false;
        }
        
    }
}
