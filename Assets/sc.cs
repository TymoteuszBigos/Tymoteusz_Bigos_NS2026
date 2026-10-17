using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    { 
        List<int> dane = new List<int> { 1, 2, 3, 2, 1, 2, 1, 2, 2};
        List<int> jedynki = new List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();

        foreach (int i in dane)
        {
            if (i == 1)
            {
                jedynki.Add(i);
 

            }
            else if (i == 2)
            {
                dwojki.Add(i);
            }
            else if (i == 3)
            {
                trojki.Add(i);
                
            }
            else
            {
                Debug.Log("Nieznana liczba: " + i);
            }

        }
        Debug.Log("Ilosc Jedynek: " + jedynki.Count);
        Debug.Log("Ilosc Dwojki: " + dwojki.Count);
        Debug.Log("Ilosc Trojek: " + trojki.Count);
        Debug.Log(dane.Count);
        dane.Clear();
        Debug.Log(dane.Count);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Test()
    {
        return 1;
    }

}
