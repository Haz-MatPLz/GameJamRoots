using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trading : MonoBehaviour
{
    public moneyandyeah Coins;
    public Stuff Nutrients;
    public Text coins;
    public treeinfo tree;
    string NutriantType;

    // Start is called before the first frame update
    void Start()
    {
    }


    public void Buy1F()
    {
        string treeName = tree.treeName;

        switch (treeName)
        {
            case "Calcium Tree":
                SetBuy1("Calcium");
                break;
            case "Magnesium Tree":
                SetBuy1("Magnesium");
                break;
            case "Sulfur Tree":
                SetBuy1("Sulfur");
                break;
            case "Nitrogen Tree":
                SetBuy1("Nitrogen");
                break;
            case "Phosphorus Tree":
                SetBuy1("Phosphorus");
                break;
            case "Potassium Tree":
                SetBuy1("Potassium");
                break;
            case "Neutral Tree":
                SetBuy1("Neutral");
                break;
            default:
                break;
        }
    }

    void SetBuy1(string treeType)
    {
        if (Coins.Money >= 50)
        {
            Debug.Log(treeType);
            if (treeType == "Neutral")
            {

            }
            else
            {
                Coins.Money = Coins.Money - 50;
                StartCoroutine(NutrientBought1(treeType));

            }
        }
    }


    private IEnumerator NutrientBought1(string NutrientAdd)
    {
        yield return new WaitForSeconds(10);
        var type = Nutrients.GetType();
        var property = type.GetProperty(NutrientAdd);
        var currentValue = (int)property.GetValue(Nutrients);
        property.SetValue(Nutrients, currentValue + 25);
        StartCoroutine(NutrientBought1(NutrientAdd));
    }

    void Buy2F()
    {
        string treeName = tree.treeName;

        switch (treeName)
        {
            case "Calcium Tree":
                SetBuy2("Calcium");
                break;
            case "Magnesium Tree":
                SetBuy2("Magnesium");
                break;
            case "Sulfer Tree":
                SetBuy2("Sulfer");
                break;
            case "Nitrogen Tree":
                SetBuy2("Nitrogen");
                break;
            case "Phosphorus Tree":
                SetBuy2("Phosphorus");
                break;
            case "Potassium Tree":
                SetBuy2("Potassium");
                break;
            default:
                break;
        }
    }

    void SetBuy2(string treeType)
    {
        Debug.Log(treeType);

    }

    void Buy3F()
    {
        string treeName = tree.treeName;

        switch (treeName)
        {
            case "Calcium Tree":
                SetBuy3("Calcium");
                break;
            case "Magnesium Tree":
                SetBuy3("Magnesium");
                break;
            case "Sulfer Tree":
                SetBuy3("Sulfer");
                break;
            case "Nitrogen Tree":
                SetBuy3("Nitrogen");
                break;
            case "Phosphorus Tree":
                SetBuy3("Phosphorus");
                break;
            case "Potassium Tree":
                SetBuy3("Potassium");
                break;
            default:
                break;
        }
    }

    void SetBuy3(string treeType)
    {
        Debug.Log(treeType);
    }

    void BuyNutral()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coins.text = Coins.Money.ToString();
    }
}
