using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class UI_Interaction : MonoBehaviour
{
    public GameObject zapataCorrida;
    public GameObject nombres;
    public GameObject muroDeContencion;
    public GameObject firme;
    public GameObject losaVigueta;
    public GameObject detalleLosaAligerada;

    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;
    public GameObject boton5;
    public GameObject boton6;
    
    
    public GameObject UiCanvas;
    GraphicRaycaster UiRaycaster;
    PointerEventData clickData;
    List<RaycastResult> clickResults;
    // Start is called before the first frame update
    void Start()
    {
        UiRaycaster = UiCanvas.GetComponent<GraphicRaycaster>();
        clickData = new PointerEventData(EventSystem.current);
        clickResults = new List<RaycastResult>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Mouse.current.leftButton.wasReleasedThisFrame){

            GetUiElementsClicked();
        }
    }
    void GetUiElementsClicked(){

        clickData.position = Mouse.current.position.ReadValue();
        clickResults.Clear();

        UiRaycaster.Raycast(clickData, clickResults);

        foreach(RaycastResult result in clickResults){
            
            GameObject UiElement = result.gameObject;

            
            switch (UiElement.name) 
            {
            case "panel detalle losa aligerada":
                detalleLosaAligerada.SetActive(true);

                break;
            case "panel zapata corrida":
                zapataCorrida.SetActive(true);
                break;
            case "panel nombres":
                nombres.SetActive(true);
                break;
            case "panel muro de contencion":
                muroDeContencion.SetActive(true);
                break;
            case "panel firme":
                firme.SetActive(true);
                break;
            case "panel losa vigueta":
                losaVigueta.SetActive(true);
                break;
            
            
            }
            Debug.Log(UiElement.name);

            
        }
    }

    
}
