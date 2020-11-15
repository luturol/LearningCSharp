using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparklesVFX;

    //Cached Variable
    Level level;
    GameSession gameStatus;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        level = FindObjectOfType<Level>();
        gameStatus = FindObjectOfType<GameSession>();
        level.CountBreakableBlocks();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {        
        PlayBlockDestroySFX();
        level.BlockDestroyed();    
        TriggerSparklesVFS();
        Destroy(gameObject);
    }

    private void PlayBlockDestroySFX()
    {
        gameStatus.AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
    }
    private void TriggerSparklesVFS()
    {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 2f);
    }
}
