using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{   
    //Variables de control de velocidad
    [SerializeField] float CurrentSpeed = 5, WalkingSpeed = 5, SideAndBackSpeed = 1.5f;

    //Inicializa varibles del movimiento
    float moveHorizontal, moveVertical;
    Vector3 moveCube;

    //Inicializa variables del animador
    Animator animator;
    int isRunningHash, isGoingBackHash,isGoingSideA,isGoingSideD;
    bool walkingUp, isWalkingUp, walkingBack, isWalkingBack, walkingToTheSideA, isWalkingToTheSideA, walkingToTheSideD, isWalkingToTheSideD;

    private void Start()
    {
        //Recursos del animador
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("isWalking");
        isGoingBackHash = Animator.StringToHash("WalkBack");
        isGoingSideA = Animator.StringToHash("isGoingSideA");
        isGoingSideD = Animator.StringToHash("isGoingSideD");
    }

    private void Update()
    {
        //Movimiento
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        moveCube = new Vector3(moveHorizontal , 0f, moveVertical);
        transform.Translate(moveCube * CurrentSpeed * Time.deltaTime);

        //Animate Going Up
        walkingUp = Input.GetKey("w");
        isWalkingUp = animator.GetBool(isRunningHash);

        if (walkingUp && !isWalkingUp) 
        {

            animator.SetBool(isRunningHash, true);
        
        }

        if (!walkingUp && isWalkingUp)
        {

            animator.SetBool(isRunningHash, false);

        }

        //Animate Going Back
        walkingBack = Input.GetKey("s");
        isWalkingBack = animator.GetBool(isGoingBackHash);

        if (walkingBack && !isWalkingBack)
        {

            animator.SetBool(isGoingBackHash, true);

        }

        if (!walkingBack && isWalkingBack)
        {

            animator.SetBool(isGoingBackHash, false);

        }

        //Animate Walking To The Side and Speed Control:
        //D
        walkingToTheSideD = Input.GetKey("d");
        isWalkingToTheSideD = animator.GetBool(isGoingSideD);

        if (walkingToTheSideD && !isWalkingToTheSideD)
        {

            animator.SetBool(isGoingSideD, true);
            if (!walkingUp && !walkingBack)
            CurrentSpeed = SideAndBackSpeed;

        }

        if (!walkingToTheSideD && isWalkingToTheSideD)
        {

            animator.SetBool(isGoingSideD, false);
            CurrentSpeed = WalkingSpeed;
        }

        //A
        walkingToTheSideA = Input.GetKey("a");
        isWalkingToTheSideA = animator.GetBool(isGoingSideA);

        if (walkingToTheSideA && !isWalkingToTheSideA)
        {

            animator.SetBool(isGoingSideA, true);
            if (!walkingUp && !walkingBack)
            CurrentSpeed = SideAndBackSpeed;

        }

        if (!walkingToTheSideA && isWalkingToTheSideA)
        {

            animator.SetBool(isGoingSideA, false);
            CurrentSpeed = WalkingSpeed;

        }

    }
}
