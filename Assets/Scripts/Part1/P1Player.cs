using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Player : MonoBehaviour
{

    private bool attacking = false;
    public p1Hitbox hitbox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        attacking = true;
        hitbox.gameObject.SetActive(true);
        hitbox.StartAttack();
    }

    void StopAttack()
    {
        attacking = false;
    }
}
