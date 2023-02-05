using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Stuff : MonoBehaviour
{

    public int Nitrogen = 0;
    public int Phosphorus = 0;
    public int Potassium = 0;
    public int Calcium = 0;
    public int Magnesium = 0;
    public int Sulfer = 0;
    public int Zinc = 0;
    public int Chloride = 0;
    public int Copper = 0;
    public GameObject Everything;
    public GameObject YOULOOSE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Nitrogen <= 100) {
            Everything.SetActive(false);
            YOULOOSE.SetActive(true);
        }
        if (Phosphorus <= 100)
        {
            Everything.SetActive(false);
            YOULOOSE.SetActive(true);
        }
        if (Potassium <= 100)
        {
            Everything.SetActive(false);
            YOULOOSE.SetActive(true);
        }
        if (Calcium <= 100)
        {
            Everything.SetActive(false);
            YOULOOSE.SetActive(true);
        }
        if (Magnesium <= 100)
        {
            Everything.SetActive(false);
            YOULOOSE.SetActive(true);
        }
        if (Sulfer <= 100)
        {
            Everything.SetActive(false);
            YOULOOSE.SetActive(true);
        }
    }
}
