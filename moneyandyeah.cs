using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyandyeah : MonoBehaviour
{
    public int Money = 400;
    public Stuff StuffChanger;
    // Start is called before the first frame update
    private IEnumerator WaitForASecond()
    {
        yield return new WaitForSeconds(10);
        Money = Money + 50;
        Debug.Log("50 coins added to Total, Your Total is now " + Money);
        StartCoroutine(WaitForASecond());
    }
    private IEnumerator TimeForNutrients() {
        yield return new WaitForSeconds(30);
        StuffChanger.Nitrogen = StuffChanger.Nitrogen - 25;
        StuffChanger.Phosphorus = StuffChanger.Phosphorus - 25;
        StuffChanger.Potassium = StuffChanger.Potassium - 25;
        StuffChanger.Calcium = StuffChanger.Calcium - 25;
        StuffChanger.Magnesium = StuffChanger.Magnesium - 25;
        StuffChanger.Sulfer = StuffChanger.Sulfer - 25;
        Debug.Log("All your Nutrients have been reduced by 25");
        StartCoroutine(TimeForNutrients());
    }
    void Start()
    {
        StartCoroutine(TimeForNutrients());
        StartCoroutine(WaitForASecond());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
