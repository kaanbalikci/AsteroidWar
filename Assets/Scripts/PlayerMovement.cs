using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D coll;
    

    private float hori;
    private float vert;

    
    [SerializeField] private float currentHealth = 30.0f;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private AudioClip deathsound;
    [SerializeField] private AudioClip shotsound;
    [SerializeField] private float speed1 = 10f;
    [SerializeField] private float speed2 = 10f;
    [SerializeField] private float bulletspeed = 1000f;
    [SerializeField] private GameObject SettingsPanel;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();      
    }

  
    void Update()
    {
        hori = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hori * speed1, rb.velocity.y);

        vert = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, vert * speed2);

       
        fire();
        ESCMenu();
    }

    private void fire()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale == 1.0f)
        { 
            GameObject newbullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            newbullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up*bulletspeed);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(shotsound, 1f);

            Destroy(newbullet, 4.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Meteor")
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(deathsound, 1f);
            Destroy(collision.gameObject);
            ScoreMenager.SM.LifeScore();
            health(10.0f);
        }
    }

    private void health(float heal)
    {
        currentHealth -= heal;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        
        Destroy(this.gameObject);

        GameOver.GO.GameOverUI();
    }

    private void ESCMenu()
    {
        if (Input.GetButtonDown("Cancel") && Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.0f;
            SettingsPanel.SetActive(true);
        }
        else if (Input.GetButtonDown("Cancel") && Time.timeScale == 0.0f)
        {
            Time.timeScale = 1.0f;
            SettingsPanel.SetActive(false);
        }
    }


}


