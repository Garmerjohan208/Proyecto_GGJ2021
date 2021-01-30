using UnityEngine;
using Photon.Pun;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private PhotonView photonView;

    //Inicializa variables del animador
    Animator animator;
    int isRunningHash, isGoingBackHash;
    bool forwardPressed, backPressed;
    

    private void Start()
    {
        photonView = GetComponent<PhotonView>();

        //Recursos del animador
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("IsRunning");
        isGoingBackHash = Animator.StringToHash("IsWalkingBack");

    }

    private void Update()
    {
        if (photonView.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 moveCube = new Vector3(moveHorizontal, 0, moveVertical);
            transform.Translate(moveCube * speed * Time.deltaTime);
        }


        //Update animador
        forwardPressed = Input.GetKey("w");
        backPressed = Input.GetKey("s");

        if (forwardPressed)
        {
            
            animator.SetBool(isRunningHash, true); 
        }
        else 
        {
            animator.SetBool(isRunningHash, false);
            
        }

        if (backPressed)
        {
            
            animator.SetBool(isGoingBackHash, true);
        }
        else
        {
            animator.SetBool(isGoingBackHash, false);
            
        }

        if (backPressed && forwardPressed)
        {
            animator.SetBool(isGoingBackHash, true); animator.SetBool(isRunningHash, false); 
        }
    }
}
