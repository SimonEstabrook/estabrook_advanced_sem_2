using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMaker : MonoBehaviour
{
    public enum TypeMachine
    {
        Coffee = 1,
        Cream = 2
    }

    public TypeMachine whichType;
    public GameObject leftSpout, rightSpout;

    public GameObject FullCup;
    public GameObject CreamCup;

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

        }
    }
}
