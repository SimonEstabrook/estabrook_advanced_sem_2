using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMaker : MonoBehaviour
{
    public enum TypeMachine
    {
        Coffee = 1,
        Cream = 2,
		Ice = 3
    }

    public TypeMachine whichType;
    public GameObject leftSpout, rightSpout;

    public GameObject FullCup;
    public GameObject CreamCup;
	public GameObject IceCup;
	public GameObject FullIceCup;
	public GameObject FullIceCreamCup;
	public GameObject FullMilkCup;
	public GameObject FullLatteCup;

    public void CreateCoffee(ButtonManager.WhichSide s)
    {
        if (s == ButtonManager.WhichSide.Left)
        {

            RaycastHit cup;
            if(Physics.Raycast(leftSpout.transform.position, Vector3.down, out cup, 20f))
            {

				if (cup.transform.gameObject.name.Contains("CoffeeCup_Empty"))
				{
					Instantiate(FullCup, cup.transform.position, FullCup.transform.rotation);
					Destroy(cup.transform.gameObject);
				}

				if (cup.transform.gameObject.name.Contains("CoffeeCup_Ice"))
				{
					Instantiate(FullIceCup, cup.transform.position, FullCup.transform.rotation);
					Destroy(cup.transform.gameObject);
				}

			}
        }
        else
        {
            RaycastHit cup;
            if (Physics.Raycast(rightSpout.transform.position, Vector3.down, out cup, 20f))
            {
                if (cup.transform.gameObject.name.Contains("CoffeeCup_Empty"))
                {
                    Instantiate(FullCup, cup.transform.position, FullCup.transform.rotation);
                    Destroy(cup.transform.gameObject);
                }
				if (cup.transform.gameObject.name.Contains("CoffeeCup_Ice"))
				{
					Instantiate(FullIceCup, cup.transform.position, FullCup.transform.rotation);
					Destroy(cup.transform.gameObject);
				}
			}
            
        }

    }

    public void AddCream()
    {

        RaycastHit cup;
        if (Physics.Raycast(leftSpout.transform.position, Vector3.down, out cup, 20f))
        {

			if (cup.transform.gameObject.name.Contains("CoffeeCup_Full"))
			{
				Debug.Log("Is this activating?" + cup.transform.name);

				Instantiate(CreamCup, cup.transform.position, FullCup.transform.rotation);
				Destroy(cup.transform.gameObject);
			}

			if (cup.transform.gameObject.name.Contains("CoffeeCup_Ice_Full"))
			{
				Debug.Log("Is this activating?" + cup.transform.name);

				Instantiate(FullIceCreamCup, cup.transform.position, FullCup.transform.rotation);
				Destroy(cup.transform.gameObject);
			}


		}
    }

	public void AddIce()
	{
		Debug.Log("Check");
		RaycastHit cup;
		if (Physics.Raycast(leftSpout.transform.position, Vector3.down, out cup, 20f))
		{

			if (cup.transform.gameObject.name.Contains("CoffeeCup_Clear_Empty"))
			{
				Debug.Log("Is this activating?" + cup.transform.name);

				Instantiate(IceCup, cup.transform.position, FullCup.transform.rotation);
				Destroy(cup.transform.gameObject);
			}

		}
	}

	public void FillMilk()
	{
		Debug.Log("Check");
		RaycastHit cup;
		if (Physics.Raycast(rightSpout.transform.position, Vector3.down, out cup, 20f))
		{

			if (cup.transform.gameObject.name.Contains("MilkCup_Empty"))
			{
				Debug.Log("Is this activating?" + cup.transform.name);

				Instantiate(FullMilkCup, cup.transform.position, FullMilkCup.transform.rotation);
				Destroy(cup.transform.gameObject);
			}

		}
	}

	public void Espresso()
	{
		Debug.Log("Check");
		RaycastHit cup;
		if (Physics.Raycast(leftSpout.transform.position, Vector3.down, out cup, 20f))
		{

			if (cup.transform.gameObject.name.Contains("Latte_Empty"))
			{
				Debug.Log("Is this activating?" + cup.transform.name);

				Instantiate(FullLatteCup, cup.transform.position, FullLatteCup.transform.rotation);
				Destroy(cup.transform.gameObject);
			}

		}
	}

	public void AddItem()
	{
		
	}
}
