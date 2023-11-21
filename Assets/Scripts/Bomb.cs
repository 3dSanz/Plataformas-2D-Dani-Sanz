using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
[SerializeField] private float radio;
[SerializeField] private float fuerzaExplo;
Animator _anim;

    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.layer == 9)
        {
            _anim.SetBool("TimeoutBomb", true);
        }
    } 

    public void IsExplosion()
    {
        _anim.SetBool("TimeoutBomb", false);
        _anim.SetBool("IsExplosion", true);
    }

    public void Explosion()
    {
        SFXManager.instance.PlaySound(SFXManager.instance.explosion);
        Collider2D[] personajePrincipal = Physics2D.OverlapCircleAll(transform.position, radio);
        foreach (Collider2D colisioner in personajePrincipal)
        {
            Player _player = colisioner.GetComponent<Player>();
            if (_player != null)
            {
                _player.PlayerDamage();
            }
        }

        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, radio);
        foreach (Collider2D colisioner in objects)
        {
            Rigidbody2D rb2d = colisioner.GetComponent<Rigidbody2D>();
            if(rb2d != null)
            {
                Vector2 direction = colisioner.transform.position - transform.position;
                float distance = 1 + direction.magnitude;
                float finalForce = fuerzaExplo / distance;
                rb2d.AddForce(direction * finalForce);
            }
        }
        
    }

    void GoodbyeBomb()
    {
        Destroy(this.gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radio);
    }
}
