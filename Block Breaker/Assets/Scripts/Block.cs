using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    //Cached Variable
    Level level;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.BlockDestroyed();
        Destroy(gameObject);
    }
}
