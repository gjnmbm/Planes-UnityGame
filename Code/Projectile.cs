using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public LayerMask whatIsSolid;
    public int damage;
    public static AudioClip shoot;
    public AudioSource laser;
    // Start is called before the first frame update
    void Start()
    {
        shoot = Resources.Load<AudioClip>("LaserNoise");
        Invoke("DestroyProjectile", lifetime);
        laser.PlayOneShot(shoot);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance, whatIsSolid);
        if (hitInfo.collider != null) {
            if (hitInfo.collider.CompareTag("Enemy")) {
                hitInfo.collider.GetComponent<EnemyMovement>().TakeDamage(damage);
                DestroyProjectile();
            }
        }
        transform.Translate(transform.right * speed * Time.deltaTime);
    }

    void DestroyProjectile() {
        Destroy(gameObject);
    }
}
