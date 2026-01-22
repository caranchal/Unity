using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private PlayerInputAction InputAction;


    private void Awake()
    {
        InputAction = new PlayerInputAction();
        InputAction.Player.Enable();

    }
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = InputAction.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

       
    }
}
