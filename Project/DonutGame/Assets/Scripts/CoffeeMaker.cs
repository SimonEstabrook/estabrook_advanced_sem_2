using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMaker : MonoBehaviour
{
    public GameObject leftSpout, rightSpout;

    public GameObject CoffeeObject;

    public void CreateCoffee(ButtonManager.WhichSide s)
    {
        for(int i = 0; i < 50; i++)
        {
            if (s == ButtonManager.WhichSide.Left)
            {

                Instantiate(CoffeeObject, leftSpout.transform.position, CoffeeObject.transform.rotation);
            }
            else
            {
                Instantiate(CoffeeObject, rightSpout.transform.position, CoffeeObject.transform.rotation);

            }

        }
    }
}
