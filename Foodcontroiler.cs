using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Foodcontroiler : MonoBehaviour
{
   public Image currentFood;
   public Text txt;
   public float food = 100;
   private float maxfood = 100;
   public static Foodcontroiler instance;
    void Start()
    {
        instance = this;
        InvokeRepeating("updateFoodHealth", 1.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        float radio = food / maxfood;
        currentFood.rectTransform.localScale = new Vector3(radio, 1, 1);
        txt.text = (radio * 100) + " % ";
    }
    void updateFoodHealth()
    {
        if (food > 0)
        {
            food -= 1f;
        }
    }
    public void healingFood()
    {
        food += 10;
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
}
