using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{

    public int maxHealth;
    private int currentHealth;

    UICanvasController healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar = FindObjectOfType<UICanvasController>();
        healthBar.SetMAxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amountofDamage)
    {

        currentHealth -= amountofDamage;

        healthBar.SetHealth(currentHealth);


        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<GameManager>().PlayerRespawn();
        }

    }


}
