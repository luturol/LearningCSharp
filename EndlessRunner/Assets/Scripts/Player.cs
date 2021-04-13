using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Interactable
{    
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float speed;
    [SerializeField] Transform jumpPosition;

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
        if(moveInput.y > 0)
        {
            Debug.Log(moveInput.y);
            var move = Vector3.MoveTowards(rigidbody.position, jumpPosition.position, speed * Time.fixedDeltaTime);
            rigidbody.MovePosition(move);
        }
    }
}
