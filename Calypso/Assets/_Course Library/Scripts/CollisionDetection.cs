using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetection : MonoBehaviour
{
    private int health = 100;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {

    }

void onTriggerEnter(Collider other){
    if (other.gameObject.tag == "gameOverCollision") {
       UpdateHealth(-health);
    }
}

public void UpdateHealth(int healthToSubtract){
    health -= healthToSubtract;
    if (health <= 0) 
    {
        
        healthText.text = "Health: " + health;
    
    }
}

    // Update is called once per frame
    void Update()
    {
     //if (gameObject.tag == "whatIsPlayer".position <= gameObject.tag == "gameOverCollision".position){
        UpdateHealth(health);
    // }
        
    }
}