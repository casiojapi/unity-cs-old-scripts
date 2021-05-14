using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    public GameObject hit;
    public int heal = 0;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) 
     {
        if (other.CompareTag("Player")) {
            Instantiate(hit, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            
            other.GetComponent<Player>().health -= damage;
            other.GetComponent<Player>().health += heal;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);


        }

    }
}
