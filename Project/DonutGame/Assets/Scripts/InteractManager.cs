using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : MonoBehaviour {

	public GameObject PickupPoint, HoldPoint;
	public GameObject MainCamera;

	public RaycastHit PointedObject;

	public GameObject lastHit;
	private int lastHitLayer;
	public GameObject hitObject;
	public GameObject HoldObject;
	private bool HoldingObject = false;

	void Start () {
		
	}
	
	void Update () {
		#region HOLDSTUFF
		Debug.DrawLine(MainCamera.transform.position, PickupPoint.transform.position, Color.cyan);
		if(Physics.Linecast(MainCamera.transform.position, PickupPoint.transform.position, out PointedObject))
		{
			
			if(PointedObject.transform.gameObject.tag == "Physics")
			{
				hitObject = PointedObject.transform.gameObject;
				if(lastHit != hitObject)
				{
					if(lastHit == null)
					{
						lastHit = hitObject;
						lastHitLayer = lastHit.layer;
						hitObject.layer = 9;
					}
					else
					{
						lastHit.layer = lastHitLayer;
						lastHit = hitObject;
						lastHitLayer = lastHit.layer;
						hitObject.layer = 9;
					}

				}
				
			}
			else
			{
				lastHit.layer = lastHitLayer;
				hitObject = null;
				lastHit = null;
			}

		}
		#endregion

		if(hitObject != null && Input.GetKeyDown(KeyCode.E) && !HoldingObject)
		{
			HoldObject = hitObject;

			HoldObject.transform.position = HoldPoint.transform.position;
			HoldObject.transform.parent = HoldPoint.transform;
			HoldingObject = true;
			//hitObject.GetComponent<Rigidbody>().isKinematic = true;
			HoldObject.GetComponent<Rigidbody>().useGravity = false;
			HoldObject.GetComponent<Collider>().enabled = false;
		}

		if(HoldingObject)
		{
			HoldObject.transform.position = HoldPoint.transform.position;
		}
		

		if(HoldingObject && Input.GetKeyDown(KeyCode.R))
		{
			HoldObject.transform.parent = null;
			HoldingObject = false;

			//hitObject.GetComponent<Rigidbody>().isKinematic = false;
			HoldObject.GetComponent<Rigidbody>().useGravity = true;
			HoldObject.GetComponent<Collider>().enabled = true;
		}

	}
}
