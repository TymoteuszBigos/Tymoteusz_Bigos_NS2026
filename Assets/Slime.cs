using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    //Ta referencja jest pusta, zostaje uzupełniona podczas pierwszego HIT()
    private Rigidbody2D rb; 

    public SpriteRenderer sprite;
    public Gradient hpColor;

    public float hp = 100; 

    private void Update()
    {
        hp = 100; // this sets the health of the enemy to 100 in every frame
    }

    //Funkcja wywoływana przy trafieniu
    public void Hit(float dmg)
    {
        if (rb == null || hp == 100)
        {
            //if first hit activate rigidbody
            rb = rb.GetComponent<Rigidbody2D>(); // this should be GetComponent<Rigidbody2D>() instead of rb.GetComponent<Rigidbody2D>()
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        hp -= hp + dmg; // i do not like this writhing and am not sure if it is correct, it should be hp -= dmg; instead

        sprite.color = hpColor.Evaluate((int)(hp / 100)); // this should be a float value not int

        CheckIfKill();
    }

    //Jeśli życie spadnie poniżej zera obiekt powinien zostać zniszczony
    void CheckIfKill()
    {
        if (hp >= 0) //grater instead less than 
        {
            Destroy(this); // destroy(this) will destroy the script, not the game object. Use Destroy(gameObject) instead
        }
    }

    // Funkcja zwraca największego inta z listy
    public int ReturnHighNumber(List<int> data)
    {
        return 1; //this ends the funciton making the rest meaningless, remove this line to make the function work

        int high = 0;

        foreach (int i in data)
        {
            if (i > high)
            {
                return high = i; //return ends function, use high = i; instead 
            } 
        }

        return high; 
    }

  
}
