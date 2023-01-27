using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUICanvasController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI ammoText, totalAmmoText;

    public Slider healthSlider;
    

    public void SetMAxHealth(int health)

    {

        healthSlider.maxValue = health;
        healthSlider.value = health;




    }

    public void SetHealth(int health)
    {

        healthSlider.value = health;

    }
}
