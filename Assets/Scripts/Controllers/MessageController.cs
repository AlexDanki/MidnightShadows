using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class MessageController : MonoBehaviour
{
    public TextMeshProUGUI messageText;

    public GameObject messageContainerUi; // GameObject que contem o texto da mensagem

    public MessageData messageData;

    bool menssagemIsOpen = false;

    MessageUiController messageUiController;

    private void Awake()
    {
        messageUiController = FindAnyObjectByType<MessageUiController>();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (menssagemIsOpen) 
        {
            if(Keyboard.current.escapeKey.wasPressedThisFrame || Keyboard.current.enterKey.wasPressedThisFrame) 
            {
                CloseMessage();
            }
        }
    }

    public void Action() 
    {

        ShowMessage(true, messageData.Message);

        StopPlayerMoviment(true);

        UsageUI.instance.HideRawImage();
    }

    public void CloseMessage() 
    {
        ShowMessage(false, "");

        StopPlayerMoviment(false);

        UsageUI.instance.ShowRawImage();
    }

    private void ShowMessage(bool show, string message) 
    {
        messageContainerUi?.SetActive(show);
        messageUiController.SetMessagesActive(show);

        menssagemIsOpen = show;
        messageText.text = message;
    }

    private void StopPlayerMoviment(bool stop) 
    {
        PlayerController.instance.stopMotion = stop;
        CameraController.instance.stopRotation = stop;
    }

}
