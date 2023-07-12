using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : MonoBehaviour {
    public string monsterName;
    public int health;
    public int attackDamage;
    public float moveSpeed;
    
    public Rigidbody2D rb;
    public Animator animator;

    public virtual void Attack()
    {
        // 몬스터의 공격 동작 구현
    }

    public virtual void TakeDamage(int damage)
    {
        // 몬스터가 피해를 받을 때 동작 구현
    }
}