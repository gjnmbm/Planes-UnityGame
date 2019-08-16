using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(1, 5);
        speed = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * -1 * speed * Time.deltaTime);
        DeadCheck();
    }

    public void TakeDamage(int damage) {
        health -= damage;

    }
    void DeadCheck()
    {
        if (health <= 0)
        {
            EnemySound.PlaySound("explosion");
            ScoreChanger.points += 10;
            Destroy(gameObject);
        }
        if (transform.position.x <= -5) {
            Destroy(gameObject);
        }
    }
}
