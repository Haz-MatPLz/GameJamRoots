using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    private GraphicRaycaster graphicRaycaster;

    private void Start()
    {
        graphicRaycaster = GetComponent<GraphicRaycaster>();
    }

    private void Update()
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        graphicRaycaster.Raycast(pointerEventData, results);

        if (results.Count > 0)
        {
            Cursor.visible = false;
            // The user is interacting with a UI element, block input to objects behind the UI
        }
        else
        {
            Cursor.visible = true;
            // The user is not interacting with a UI element, allow input to objects behind the UI
        }
    }
}