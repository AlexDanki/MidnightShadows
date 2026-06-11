using UnityEngine;
using UnityEngine.Events;

public class IteractableManager : MonoBehaviour
{
    public UnityEvent onInterect;
    public UnityEvent autoInteract;

    public bool hasActionInput;
    public bool autoInteracted;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IteractAction() 
    {
        // chamada da iteração aqui
        print("Chamado");
        onInterect.Invoke();
    }

    public void AutoAction() 
    {
        autoInteract.Invoke();
    }
}
