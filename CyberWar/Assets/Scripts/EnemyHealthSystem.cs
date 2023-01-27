using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{


    private int currentHealth;
    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void TakeDamage(int damageAmount)

    {
        currentHealth -=damageAmount;


        if(currentHealth <= 0)

        { 
            Destroy(gameObject);
        }
                
               
                
              

    }






}
