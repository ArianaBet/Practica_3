using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class BotonesMenu : MonoBehaviour
{
    Box Menu;

    bool estarenpantalla;

    Button Arboles;
    Button Cultivos;
    Button Flores;
    Button volver;

    public bool subarboles;
    public bool subcultivos;
    public bool subflores;
    public bool subvolver;
    // Start is called before the first frame update
    void Start()
    {
        subarboles = false;
        subcultivos = false;
        subflores = false;
        subvolver = false;

       UIDocument uid = this.gameObject.GetComponent<UIDocument>();
        var root = uid.rootVisualElement;
        Menu = root.Q<Box>("box");

        Arboles = root.Q<Button>("button_1");
        Cultivos = root.Q<Button>("button_2");
        Flores = root.Q<Button>("button_3");
        volver = root.Q<Button>("button_5");

        Arboles.clicked += () => subarboles = true;
        Cultivos.clicked += () => subcultivos = true;
        Flores.clicked += () => subflores = true;
        volver.clicked += () => subvolver = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
