using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    [SerializeField] private GameObject[] Meteor;
    public static GameMenager GM;
    [SerializeField] private float Delay = 2.0f;
    private float nextTime;
    private int whichMet;
    public float meteoritSpeeed = 200f;

    private void Awake()
    {
        GM = this;
    }

    void Update()
    {
        if(Delay >= 0.1f)
        {
            Delay -= 0.02f * Time.deltaTime;
        }

        if (shouldSpawn())
        {
            Spawn();
        }
        whichMet = Random.Range(0, Meteor.Length);
        if (meteoritSpeeed <= 500.0f)
        { 
            meteoritSpeeed += 3f * Time.deltaTime;
        }
    }

    void Spawn()
    {
        nextTime = Time.time + Delay;
        Instantiate(Meteor[whichMet], transform.position, Quaternion.identity);
    }

    private bool shouldSpawn()
    {
        return Time.time >= nextTime;
    }

}
