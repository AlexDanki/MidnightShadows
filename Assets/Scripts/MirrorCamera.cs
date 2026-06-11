using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MirrorCamera : MonoBehaviour
{
    public Camera playerCamera;   // câmera principal (do jogador)
    private Camera mirrorCamera;
    public float maxZOffset = 0.5f; // limite de deslocamento no eixo Z
    float defaultX;
    float defaultZ;

    void Start()
    {
        mirrorCamera = GetComponent<Camera>();
        defaultX = transform.position.x;
        defaultZ = transform.position.z; // guarda o Z inicial
    }

    private void Update()
    {
        Vector3 targetPosition = playerCamera.transform.position;

        // Mantém X fixo
        targetPosition.x = defaultX;
        targetPosition.z = defaultZ;

        /*// Calcula deslocamento do player em Z e inverte
        float offsetZ = targetPosition.z - defaultZ;
        targetPosition.z = defaultZ - offsetZ;

        // Limita Z dentro do intervalo [defaultZ - 0.5, defaultZ + 0.5]
        targetPosition.z = Mathf.Clamp(targetPosition.z, defaultZ - maxZOffset, defaultZ + maxZOffset);*/

        // Aplica posição
        transform.position = targetPosition;

    }

}
