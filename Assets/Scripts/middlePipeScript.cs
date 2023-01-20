using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlePipeScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript bird;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bird.birdIsAlive == true)
        {
            logic.addScore();
        }
    }
}
