using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetection : MonoBehaviour
{
    private int health;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth(100);
    }

void onTriggerEnter(Collider other){
    if (other.gameObject.tag == "gameOverCollision" <= other.transform.tag == "whatIsEnemy") {
       UpdateHealth(-100);
    }
}

public void UpdateHealth(int healthToSubtract){
    health -= healthToSubtract;
    if (health <= 0) 
    {
        Invoke(nameof(Destroy(other.transform.tag == "whatIsEnemy")), 0.5f);
        healthText.text = "Health: " + health;
    
    }
    
}
    //     

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
