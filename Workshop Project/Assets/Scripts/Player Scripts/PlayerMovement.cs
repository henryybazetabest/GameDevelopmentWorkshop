using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 5f;
    public Rigidbody2D RB;
    public Vector2 Movement;

    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private float _horizontal;
    private float _vertical;

    [SerializeField] public int redEnergy = 0;
    [SerializeField] public int blueEnergy = 0;
    [SerializeField] public int yellowEnergy = 0;

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        FlipSprite();
    }


    private void Awake()
    {
        _animator = GetComponent<Animator>(); // needed for telling the animator to change values
        _spriteRenderer = GetComponent<SpriteRenderer>(); // needed for flipping sprite to face direction
    }

    private void FlipSprite()
    {
        // flip the sprite to face the left when moving left
        if (Movement.x < 0)
            _spriteRenderer.flipX = true;

        // flip the sprite to face right when moving right
        if (Movement.x > 0)
            _spriteRenderer.flipX = false;

        if (Movement.x < 0)
            _spriteRenderer.flipX = true;

        // flip the sprite to face right when moving right

        if ((Movement.x == 0) && (Movement.y == 0))// sets walking false if idle 0,0
        {
            _animator.SetBool("isWalking", false);
        }

        if ((Movement.x > 0) || (Movement.x < 0))// sets walking true if walking on x
        {
            _animator.SetBool("isWalking", true);
        }

        if ((Movement.y > 0) || (Movement.y < 0))// sets walking true when walking on y
        {
            _animator.SetBool("isWalking", true);
        }

        if ((Movement.y > 0)) // sets walking up if y higher then 0
        {
            _animator.SetBool("isWalkingUp", true);
            _animator.SetBool("isWalkingDown", false);
        }

        if (Movement.y < -.5)// sets walkingdown to true if y lower then 0
        {
            _animator.SetBool("isWalkingDown", true);
            _animator.SetBool("isWalkingUp", false);
        }
        if (Movement.y == 0) //sets both to false
        {
            _animator.SetBool("isWalkingDown", false);
            _animator.SetBool("isWalkingUp", false);
        }


    }



    private void FixedUpdate()
    {
        RB.MovePosition(RB.position+Movement * PlayerSpeed * Time.fixedDeltaTime);
    }

    public void redCharge(int amount)
    {
        redEnergy += amount;
    }

    public void blueCharge(int amount)
    {
        blueEnergy += amount;
    }
    public void yellowCharge(int amount)
    {
        yellowEnergy += amount;
    }


}
