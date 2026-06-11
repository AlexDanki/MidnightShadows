using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Messages/Postit")]
public class MessageData : ScriptableObject
{
    [TextArea(3, 10)]
    public string Message;
}
