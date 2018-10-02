using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public enum ButtonType
    {
        CoffeeMaker = 0,
        CupStack = 1,
        Cream = 2
    }

    public enum WhichSide
    {
        Left = 0,
        Right = 1
    }

    public WhichSide side;
    public ButtonType Type;

    public GameObject emptyCup;

    private GameObject Parent;
    private void Start()
    {
        if(transform.parent != null)
        {
            Parent = transform.parent.gameObject;

        }
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
            case ButtonType.CupStack:
                InteractManager.instance.CreateCup(emptyCup);
                break;
            case ButtonType.Cream:

                if (Parent.GetComponent<CoffeeMaker>())
                {

                    Parent.GetComponent<CoffeeMaker>().AddCream();
                }
                break;

        }
    }
}
