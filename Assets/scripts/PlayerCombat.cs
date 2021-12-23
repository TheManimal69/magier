using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    //attack point
    public Transform attackPoint;
    public float attackRange = 0.05f;

    public LayerMask enemyLayers;

    public float attackDamage = 1;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Attack();
        }
    }

    void Attack() {
        animator.SetTrigger("atac");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies) 
        {

            Debug.Log("we hit a rapscallion " + enemy.name);


            enemy.GetComponent<EnemyAI>().ProcessHit(attackDamage);
            //angled bracket< >
        }
    }

    void OnDrawGizmos()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);



    }

}
