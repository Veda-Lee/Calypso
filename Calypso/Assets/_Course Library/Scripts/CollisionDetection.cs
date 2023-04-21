using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetection : MonoBehaviour
{
    private int health = 100;
    public TextMeshProUGUI healthText;
    private Transform player = null;
    private Transform enemy = null;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth(health);
    }

//  void onTriggerEnter(Collider other){
//      if (other.gameObject.tag == "gameOverCollision") {
// //       UpdateHealth(health);
//         Debug.Log("collision detected");
//    }
//    else{
//         Debug.Log("No collision detected");
//    }
//  }

 public void UpdateHealth(int healthToSubtract){
    //  if (player.transform.position != null){
    //     health -= healthToSubtract;
    //     healthText.text = "Health: " + health;
    //  }
    //  else{
        healthText.text = "Health: " + health;
    // }
//     
}

    // Update is called once per frame
    void Update()
    {
     //if (gameObject.tag == "whatIsPlayer".position <= gameObject.tag == "gameOverCollision".position){

    // }
        
    }
}