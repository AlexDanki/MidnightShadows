using UnityEngine;

public class MessageUiController : MonoBehaviour
{
    public GameObject messages;

    void Awake()
    {
        // Desativa todos os game ob
        /*foreach (Transform go in messages.transform)
        {
            go.gameObject.SetActive(false);
        }*/

        SetMessagesActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  SetMessagesActive( bool active) 
    {
        messages.SetActive(active);
    }
}
