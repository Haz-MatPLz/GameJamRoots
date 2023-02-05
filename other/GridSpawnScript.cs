using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawnScript : MonoBehaviour
{
    public GameObject Calcium;
    public GameObject Magnesium;
    public GameObject Nitrogen;
    public GameObject Nutral;
    public GameObject Phosphorus;
    public GameObject Potassium;
    public GameObject Sulfur;
    public int GridX;
    public int GridY;
    public float gridOffset = 3.5f;
    public Vector3 gridOrigin = Vector3.zero;
    public int minimumObjects = 2;
    public int minimumNutral = 4;

    private int calciumCount = 0;
    private int magnesiumCount = 0;
    private int nitrogenCount = 0;
    private int nutralCount = 0;
    private int phosphorusCount = 0;
    private int potassiumCount = 0;
    private int sulfurCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
        for (int x = 0; x < GridX; x++)
        {
            for (int y = 0; y < GridY; y++)
            {
                Vector3 spawnPosition = new Vector3(x * gridOffset, y * gridOffset, 0) + gridOrigin;
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
        }
    }

    void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        GameObject selectedObject;
        if (nutralCount < minimumNutral)
        {
            selectedObject = Nutral;
        }
        else
        {
            int totalCount = calciumCount + magnesiumCount + nitrogenCount + phosphorusCount + potassiumCount + sulfurCount;
            if (totalCount < minimumObjects * 6)
            {
                int randomIndex = Random.Range(0, 6);
                switch (randomIndex)
                {
                    case 0:
                        if (calciumCount < minimumObjects)
                        {
                            selectedObject = Calcium;
                            calciumCount++;
                        }
                        else
                        {
                            selectedObject = Nutral;
                            nutralCount++;
                        }
                        break;
                    case 1:
                        if (magnesiumCount < minimumObjects)
                        {
                            selectedObject = Magnesium;
                            magnesiumCount++;
                        }
                        else
                        {
                            selectedObject = Nutral;
                            nutralCount++;
                        }
                        break;
                    case 2:
                        if (nitrogenCount < minimumObjects)
                        {
                            selectedObject = Nitrogen;
                            nitrogenCount++;
                        }
                        else
                        {
                            selectedObject = Nutral;
                            nutralCount++;
                        }
                        break;
                    case 3:
                        if (phosphorusCount < minimumObjects)
                        {
                            selectedObject = Phosphorus;
                            phosphorusCount++;
                        }
                        else
                        {
                            selectedObject = Nutral;
                            nutralCount++;
                        }
                        break;
                    case 4:
                        if (potassiumCount < minimumObjects)
                        {
                            selectedObject = Potassium;
                            potassiumCount++;
                        }
                        else
                        {
                            selectedObject = Nutral;
                            nutralCount++;
                        }
                        break;
                    case 5:
                        if (sulfurCount < minimumObjects)
                        {
                            selectedObject = Sulfer;
                            sulfurCount++;
                        }
                        else
                        {
                            selectedObject = Nutral;
                            nutralCount++;
                        }
                        break;
                }
            }
            else
            {
                GameObject[] objects = { Calcium, Magnesium, Nitrogen, Phosporus, Potassium, Sulfer };
                int[] counts = { calciumCount, magnesiumCount, nitrogenCount, phosphorusCount, potassiumCount, sulfurCount };

                int index;
                do
                {
                    index = Random.Range(0, objects.Length);
                    count = counts[index];
                } while (count >= minimumObjects);

                selectedObject = objects[index];
                counts[index]++;
            }
        }

        GameObject clone = Instantiate(selectedObject, positionToSpawn, rotationToSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }
}