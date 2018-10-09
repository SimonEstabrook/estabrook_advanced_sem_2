using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public enum ButtonType
    {
        CoffeeMaker = 0,
        CupStack = 1,
        Cream = 2,
		Ice = 3,
		OvenDoor = 4,
		OvenButton = 5,
		Box = 6
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
			case ButtonType.Ice:
				if(Parent.GetComponent<CoffeeMaker>())
				{
					Parent.GetComponent<CoffeeMaker>().AddIce();
				}
				break;
			case ButtonType.OvenDoor:
				if(GetComponent<OvenManager>())
				{
					GetComponent<OvenManager>().OpenDoor();
				}
				break;
			case ButtonType.OvenButton:
				Debug.Log("Finds Button");
				if(Parent.GetComponent<OvenManager>())
				{
					Debug.Log("is child");
					Parent.GetComponent<OvenManager>().CookFood();
				}
				break;
			case ButtonType.Box:
				
				InteractManager.instance.CreateCup(emptyCup);
				
				break;

        }
    }
}
