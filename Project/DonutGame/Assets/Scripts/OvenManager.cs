using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenManager : MonoBehaviour
{
	private MeshFilter MF;

	[SerializeField] private Mesh OpenDoorMesh, CloseDoorMesh;

	public bool isOpen = false;

	public bool isFull = false;
	public bool isOn = false;

	public ColliderCheck trigger;

	public GameObject Light;
	public Material LightColorOn, LightColorOff;

    // Start is called before the first frame update
    void Start()
    {
		MF = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
		isFull = false;

		for (int i = 0; i < trigger.hitObjects.Count; i++)
		{
			if (trigger.hitObjects[i].name.Contains("Tray"))
			{
				isFull = true;
			}
		}

		if (isOpen)
		{
			MF.mesh = OpenDoorMesh;
		}
		else
		{
			MF.mesh = CloseDoorMesh;
		}

		if(isFull && !isOpen)
		{
			Light.GetComponent<MeshRenderer>().material = LightColorOn;
		}
		else
		{
			Light.GetComponent<MeshRenderer>().material = LightColorOff;
		}

		
    }

	public void OpenDoor()
	{
		if(!isOn)
		{
			isOpen = isOpen ? false : true;
		}
	}

	


}
