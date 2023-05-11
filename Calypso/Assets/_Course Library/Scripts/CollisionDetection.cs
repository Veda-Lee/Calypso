using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    private int health = 100;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI gameOverText;
    private Transform player = null;
    public GameObject EndMenu;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth(health);
    }

void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "gameOverCollision"){
         //   Debug.Log(other.gameObject.tag);
            player = other.transform;
            UpdateHealth(health);
            }
        }

 public void UpdateHealth(int healthToSubtract){
    healthToSubtract = 50;
    healthText.text = "Health: " + health;
     if (player != null){
       // Debug.Log(health);
         health -= healthToSubtract;
         healthText.text = "Health: " + health;
         GameOver();
     }
     else{
        healthText.text = "Health: " + health;
     }
}

void GameOver(){
    if (health <= 0){
        EndMenu.SetActive(true);
      //  gameOverText.text=""+gameOverText;
        Debug.Log(player);
       // ResetTheGame();
        // GameObject.tag.Find("Enemy").GetComponent<Patrol>().enabled = false;
    }
    else{

    }
}
    // public void ResetTheGame(){
        
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //     print("Button working");
    //     isGameActive = false;
    // }
   
    // Update is called once per frame
    void Update()
    {
       
    }
}