using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Player player;
    private Animator animator;
    private const string IS_WALKING = "IsWalking";


    
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsWalking", false);
    }

    private void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
