using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIteract : MonoBehaviour
{
    public Transform rayCastPosition; // Camera do player de onde sairá o raio
    public LayerMask iteractableMask;

    GameObject obj;
    IteractableManager iteractableManager;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(rayCastPosition.position, rayCastPosition.forward, out hit, 1.5f, iteractableMask)) 
        {
            if(obj == null) 
            {
                obj = hit.transform.gameObject;

                iteractableManager = obj.GetComponent<IteractableManager>();

                AutoIteract autoIteract = obj.GetComponent<AutoIteract>();
                if (iteractableManager != null && iteractableManager.autoInteracted)
                {
                    iteractableManager.AutoAction();
                }

                UsageUI.instance.ShowRawImage();
            }
        }
        else 
        {
            obj = null;
            UsageUI.instance.HideRawImage();
        }

        if (obj != null)
        {

            if (Keyboard.current.eKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
            {
                
                if(iteractableManager != null && iteractableManager.hasActionInput)
                    iteractableManager.IteractAction();
            }   

        }
        else 
        {
            if (iteractableManager != null && iteractableManager.autoInteracted)
            {
                iteractableManager.AutoAction();
            }

            iteractableManager = null;
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(rayCastPosition.position, rayCastPosition.position + transform.forward * 10);
    }
}
