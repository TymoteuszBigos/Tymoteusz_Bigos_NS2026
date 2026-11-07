using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad1 : MonoBehaviour
{
    public GameObject[] gameObjects;
    public GameObject test;
    public Gradient grad1;
    public Gradient grad2;
    float changeparameter;
    Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckSet", 0, 1);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void CheckSet()
    {
        foreach (GameObject i in gameObjects)
        {
            Component tempComp = i.GetComponent<MeshRenderer>();
            
            if (tempComp != null)
            {

                Object3d(tempComp.transform, i.GetComponent<MeshRenderer>());
            }
           

            Component tempComp2 = i.GetComponent<SpriteRenderer>();
 
            if (tempComp2 != null)
            {
                Object2d(i.GetComponent<SpriteRenderer>());
            }


        }
    }
    void Object3d(Transform t, MeshRenderer m)
    {
        float localrot = t.localEulerAngles.y;

        changeparameter = localrot/360;
        newColor = grad2.Evaluate(changeparameter);
        m.material.color = newColor;
        Debug.Log("3d");
    }

    void Object2d(SpriteRenderer s)
    {
        changeparameter = s.transform.position.y / 100;
        newColor = grad1.Evaluate(changeparameter);
        s.material.color = newColor;

        Debug.Log("2d");

    }
}
