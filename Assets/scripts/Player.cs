using Unity.VisualScripting;
using UnityEngine;



public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotationSpeed = 10;
    [SerializeField] private GameInput gameInput;
    
    private bool isWalking;
    public bool IsWalking() { return isWalking; }

   

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        isWalking = moveDir != Vector3.zero;

        transform.forward=Vector3.Slerp(transform.forward, moveDir,rotationSpeed*Time.deltaTime);

        transform.position += moveDir*Time.deltaTime* moveSpeed;

        Debug.Log(inputVector);
    }
}

