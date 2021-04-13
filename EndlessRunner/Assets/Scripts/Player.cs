using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Interactable
{    
    [Header("Configurations")]
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float speed;
    [SerializeField] Transform jumpPosition;
    [SerializeField] int Life;

    private PlayerInput playerInput;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        playerInput = new PlayerInput();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(Life == 0)
            Life = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {        
        Move(playerInput.Player.Move.ReadValue<Vector2>());
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        playerInput.Enable();        
    }
    
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        playerInput.Disable();
    }

    private void Move(Vector3 moveInput)
    {     
        if(moveInput.y > 0 && IsInteractable)
        {            
            //var move = Vector3.MoveTowards(rigidbody.position, jumpPosition.position, speed * Time.fixedDeltaTime);
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, speed);
        }        
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if(ValidateTag(other.gameObject, "Floor"))
            SetInteractable(true);
    }

    /// <summary>
    /// OnCollisionExit is called when this collider/rigidbody has
    /// stopped touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionExit(Collision other)
    {
        if(ValidateTag(other.gameObject, "Floor"))
            SetInteractable(false);
    }

    private bool ValidateTag(GameObject gameObject, string tag)
    {
        return gameObject.tag == tag;
    }
    
    public void LoseLife() => Life--;

}
