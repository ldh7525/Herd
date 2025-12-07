using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int walkingHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        walkingHash = Animator.StringToHash("isWalking");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool(walkingHash, true);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
