using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI ammoText, totalAmmoText;

    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

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
