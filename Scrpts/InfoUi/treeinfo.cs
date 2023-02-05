using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class treeinfo : MonoBehaviour
{
    public string treeName = "WOW";
    public Text infoname;
    public Text NitrogenT;
    public Text PhosphorusT;
    public Text PotassiumT;
    public Text CalciumT;
    public Text MagnesiumT;
    public Text SulferT;
    public Slider NitrogenS;
    public Slider PhosphorusS;
    public Slider PotassiumS;
    public Slider CalciumS;
    public Slider MagnesuimS;
    public Slider SulferS;
    public Stuff script;
    public GameObject Menu;
    public Text Buy1;
    public Text Buy2;
    public Text Buy3;
    string NutriantType;
    public GameObject Buy1B;
    public GameObject Buy2B;
    public GameObject Buy3B;
    public GameObject Buy1T;
    public GameObject Buy2T;
    public GameObject Buy3T;

    // Start is called before the first frame update
    void Start()
    {
        string treeName = "WOW";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Menu.SetActive(true);
        treeName = gameObject.name;
        infoname.text = treeName;
        Debug.Log(treeName);
        int Nitrogen = script.Nitrogen;
        int Phosphorus = script.Phosphorus;
        int Potassium = script.Potassium;
        int Calcium = script.Calcium;
        int Magnesium = script.Magnesium;
        int Sulfer = script.Sulfer;

        NitrogenT.text = Nitrogen.ToString();
        PhosphorusT.text = Phosphorus.ToString();
        PotassiumT.text = Potassium.ToString();
        CalciumT.text = Calcium.ToString();
        MagnesiumT.text = Magnesium.ToString();
        SulferT.text = Sulfer.ToString();

        NitrogenS.value = Nitrogen;
        PhosphorusS.value = Phosphorus;
        PotassiumS.value = Potassium;
        CalciumS.value = Calcium;
        MagnesuimS.value = Magnesium;
        SulferS.value = Sulfer;

        switch (treeName)
        {
            case "Calcium Tree":
                SetBuyText("Calcium");
                break;
            case "Magnesium Tree":
                SetBuyText("Magnesium");
                break;
            case "Sulfer Tree":
                SetBuyText("Sulfer");
                break;
            case "Nitrogen Tree":
                SetBuyText("Nitrogen");
                break;
            case "Phosphorus Tree":
                SetBuyText("Phosphorus");
                break;
            case "Potassium Tree":
                SetBuyText("Potassium");
                break;
            case "Nutral Tree":
                SetNutralBuyText();
                break;
            default:
                break;
        }
    }

    private void SetBuyText(string nutrientType)
    {
        Buy1.text = $"Buy A contract For 25 {nutrientType} per 10 seconds, for 50 Tree Coins (but it wont unlock the Tree's around it)";
        Buy2.text = $"Buy A contract For 50 {nutrientType} per 10 seconds, for 100 Tree Coins";
        Buy3.text = $"Buy A contract For 50 {nutrientType} per 5 seconds, for 150 Tree Coins";

        Buy2B.SetActive(true);
        Buy3B.SetActive(true);
        Buy2T.SetActive(true);
        Buy3T.SetActive(true);
    }

    private void SetNutralBuyText() {
        Buy1.text = "Buy A contract to unlock all trees around this one for 100 Tree Coins";
        Buy2B.SetActive(false);
        Buy3B.SetActive(false);
        Buy2T.SetActive(false);
        Buy3T.SetActive(false);
    }
}

