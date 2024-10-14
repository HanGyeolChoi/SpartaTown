using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int Type = Animator.StringToHash("SpriteType");
    private readonly float magnitudeThreshold = 0.5f;
    public RuntimeAnimatorController Penguin;
    public RuntimeAnimatorController Knight;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Update()
    {
        if (GameManager.Instance.GetSpriteType() == SpriteType.Penguin)
        {
            animator.runtimeAnimatorController = Penguin;
        }

        else if (GameManager.Instance.GetSpriteType() == SpriteType.Knight)
        {
            animator.runtimeAnimatorController = Knight;
        }
    }
    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnitudeThreshold);
    }
}