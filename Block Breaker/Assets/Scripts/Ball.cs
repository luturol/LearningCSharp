using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;

    Vector2 paddleToBall;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBall = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        LockBallToPaddle();
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePosition + paddleToBall;
    }
}
