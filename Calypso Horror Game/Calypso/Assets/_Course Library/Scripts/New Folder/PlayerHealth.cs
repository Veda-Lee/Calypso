using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject ThePlayer;
    public int Health = 100;
    int Damage = 50;
    public GameObject HealthDisplay;

    public GameObject EndMenu;
    public bool InAttackRange = false;
    

    // Start is called before the first frame update
    void Start()
    {
        print("Your Health Value is: "+ Health);
    }

    void OnTriggerEnter(Collider collision){
        if (collision.transform.tag == "Enemy")
        InAttackRange = true;
        StartCoroutine(HurtPlayer());
    }

void OnTriggerExit(Collider collision){
        InAttackRange = false;
    }

IEnumerator HurtPlayer(){
    while (true && InAttackRange == true){
    Health -= Damage;
    print("Enemy just hurted you! + Your health value is: " + Health);
    yield return new WaitForSeconds(3f);
    }
}

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Time.timeScale = 0;
            EndMenu.SetActive(true);
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
    }
}
