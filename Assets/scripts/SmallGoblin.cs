using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGoblin : MonoBehaviour
{
    [SerializeField] float ghp = 3;
    void OnTriggerEnter2D(Collider2D other)
    {
        BrokenShortSword brokenShortSword = other.gameObject.GetComponent<BrokenShortSword>();

        ProcessHit(brokenShortSword);
    }

    private void ProcessHit(BrokenShortSword brokenShortSword) 
    {
        ghp -= brokenShortSword.GetDamage();
        if (ghp <= 0)
        {
            Destroy(gameObject);   
        }
    }

}
//










