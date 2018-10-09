using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public enum Recipes
	{
		None = -1,
		BlackCoffee = 0,
		Coffee_Cream = 1,
		IcedCoffee = 2,
		IcedCoffee_Cream = 3,
		Hashbrowns = 4,
		Donut = 5,
		MAXCOUNT = 6
	}

	public enum DonutTypes
	{
		Chocolate = 1,
		Chocolate_Full_Glazed = 2,
		Plain_Full_Glazed = 3,
		Plain = 4,
		Plain_Glazed = 5,
		Chocolate_Glazed = 6
	}


	public Recipes CurrentRecipe = Recipes.None;

	private int DonutCount;

	public List<GameObject> Donuts;
	public List<string> DonutNames;

	public List<GameObject> NeededDonuts;

	[TextArea]
	public List<string> RecipeWords;

	public TextMeshProUGUI RecipeText, RecipeNameText;

    // Update is called once per frame
    void Update()
    {
        if(CurrentRecipe == Recipes.None || Input.GetKeyDown(KeyCode.O))
		{
			CurrentRecipe = (Recipes)Random.Range(0, (int)Recipes.MAXCOUNT);
			if(CurrentRecipe == Recipes.Donut)
			{
				RecipeWords[(int)Recipes.Donut] = "";
				DonutCount = Random.Range(1, 5);
				Debug.Log(DonutCount);
				NeededDonuts = new List<GameObject>();
				for(int i = 0; i < DonutCount; i++)
				{
					NeededDonuts.Add(Donuts[Random.Range(0, Donuts.Count)]);
					RecipeWords[(int)Recipes.Donut] += "-" + DonutNames[i] + "\n";
				}
			}
			RecipeNameText.text = CurrentRecipe.ToString();
			RecipeText.text = RecipeWords[(int)CurrentRecipe];
		}
    }
}
