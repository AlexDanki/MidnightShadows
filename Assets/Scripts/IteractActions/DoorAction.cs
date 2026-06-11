using UnityEngine;

public class DoorAction : MonoBehaviour
{
    public AudioClip doorSound;
    public Transform soundPosition;

    bool isClosed = true;
    Animator animator;

    bool prevIsClosed;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        prevIsClosed = isClosed;
    }

    // Update is called once per frame
    void Update()
    {
        if(prevIsClosed != isClosed) 
        {
            if (isClosed) 
            {
                animator.SetBool("openned", false);
                AudioSource.PlayClipAtPoint(doorSound, transform.position);
            }
            else 
            {
                animator.SetBool("openned", true);
                AudioSource.PlayClipAtPoint(doorSound, transform.position);
            }
            prevIsClosed = isClosed;
        }
    }

    public void OpenOrCloseDoor() 
    {
        print("chamado!");
        isClosed = !isClosed;
    }

}
