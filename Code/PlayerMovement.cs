using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public int health;
    public float speed;
    private float horizontalMove;
    private float verticalMove;
    public GameObject sceneMaster;
    public EnemyMovement enemy;
    public Text lives;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        verticalMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalMove, verticalMove, 0);
        if (health <= 0) {
            sceneMaster.GetComponent<SceneMaster>().OnPlayerDeath();
        }
        UpdateHealth();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
        }
    }

    private void UpdateHealth() {
        lives.text = "Lives: " + health;
    }
}
