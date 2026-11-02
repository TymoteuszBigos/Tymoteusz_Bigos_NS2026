using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad1 : MonoBehaviour
{
    public GameObject[] gameObjects;
    public GameObject test;
    public Gradient grad;
    // Start is called before the first frame update
    void Start()
    {

        CheckSet();
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

                Object3d(tempComp.transform);
            }
           

            Component tempComp2 = i.GetComponent<SpriteRenderer>();
 
            if (tempComp2 != null)
            {
                Object2d(i.GetComponent<SpriteRenderer>());
            }


        }
    }
    void Object3d(Transform t)
    {

        Debug.Log("3d");
    }

    void Object2d(SpriteRenderer s)
    {
        float changedFloatParamenter = s.transform.position.y / 100;
        Color newColor = grad.Evaluate(changedFloatParamenter);
        s.material.color = newColor;

        Debug.Log("2d");

    }
}
