using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private GameObject[] meteors;
    [SerializeField] private GameObject particle;
    [SerializeField] private float MeteorHealth = 40.0f;
    [SerializeField] private AudioClip meteordeath;
    [SerializeField] private float leftspeed = 50f;
    
    private Rigidbody2D rb;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Vector2 newPos = new Vector2(Random.Range(-6f, 13f), 8f);

        transform.position = newPos;

        rb.AddForce(new Vector2(-1f * leftspeed, -1f * GameMenager.GM.meteoritSpeeed));

    }



    private void Update()
    {
        Destroy(this.gameObject, 5f);
    }

   



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            HitDamage(10.0f);
        }
    }

    private void HitDamage(float heal)
    {
        MeteorHealth -= heal;
        if(MeteorHealth <= 0)
        {
            
            GameObject newParticle = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(newParticle, 3f);

            deathmeteor();

        }
    }
    private void deathmeteor()
    {
        ScoreMenager.SM.AddScore();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(meteordeath, 1f);
        Destroy(this.gameObject);
        
    }

}
