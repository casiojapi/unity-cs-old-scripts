using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 targetPos;
    public float yIncrement;
    public float xIncrement;
    public float speed;
   // public float maxHeight;
   // public float minHeight;
    public float leftLimit = -10;
    public float rightLimit = 10;
    public int health = 3;
    public GameObject effect;
    public TextMeshProUGUI healthDisplay;
    public GameObject gameOver;
    public GameObject jumpPop;
    public GameObject music;
    public GameObject scoreMan;
    public GameObject teBaniaste;

    //movimiento
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 20.0f;
    //movimiento

    public int numHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update() 
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
        //movimiento
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numHearts)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }
            
            
        int scoreNu = scoreMan.GetComponent<scoreManager>().score;
        healthDisplay.text = health.ToString();

        

      //  ;
    
            if ((Input.GetKeyDown(KeyCode.L)) && (transform.position.x < rightLimit))
            {
                Instantiate(jumpPop, transform.position, Quaternion.identity);
                Instantiate(effect, transform.position, Quaternion.identity);
                targetPos = new Vector2(transform.position.x + xIncrement, transform.position.y);
                transform.position = targetPos;


            }
            else if (((Input.GetKeyDown(KeyCode.K)) || (Input.GetKeyDown(KeyCode.RightShift ))) && (transform.position.x > leftLimit))
            {
                Instantiate(jumpPop, transform.position, Quaternion.identity);
                Instantiate(effect, transform.position, Quaternion.identity);
                targetPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
                transform.position = targetPos;

            }
        
        if (health >= 5)
        {
            health = 5;
        }

        if (health <= 0) //|| (scoreNu >= 149))
        {
            gameOver.SetActive(true);
            //Instantiate(teBaniaste, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


    }
    private void FixedUpdate()
    {
        //movimiento
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        //movimiento
    }
}