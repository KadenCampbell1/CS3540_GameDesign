using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySprite : MonoBehaviour
{
    public GameObject enemy;
    public float xAdjust = 0f, yAdjust = 0.3f;
    
    private bool facingRight = true;
    
    void LateUpdate()
    {
        gameObject.transform.position = new Vector3(enemy.transform.position.x + xAdjust, enemy.transform.position.y + yAdjust, -1.5f);
    }
    
    public void FlipSprite()
    {
        facingRight = !facingRight;
        
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
