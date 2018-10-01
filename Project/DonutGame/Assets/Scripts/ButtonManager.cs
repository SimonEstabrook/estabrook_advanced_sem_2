using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public enum ButtonType
    {
        CoffeeMaker = 0
    }

    public enum WhichSide
    {
        Left = 0,
        Right = 1
    }

    public WhichSide side;
    public ButtonType Type;

    private GameObject Parent;
    private void Start()
    {
        Parent = transform.parent.gameObject;
    }

    void Update()
    {
        
    }

    public void Function()
    {
        switch(Type)
        {
            case ButtonType.CoffeeMaker:
                if(Parent.GetComponent<CoffeeMaker>())
                {
                    Parent.GetComponent<CoffeeMaker>().CreateCoffee(side);
                }
                break;

        }
    }
}
