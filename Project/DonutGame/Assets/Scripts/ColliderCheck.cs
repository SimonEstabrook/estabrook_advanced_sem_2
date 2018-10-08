using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
	public bool isHit = false;
	public List<GameObject> hitObjects;

    // Start is called before the first frame update
    void Start()
    {
		hitObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hitObjects.Count > 0)
		{
			isHit = true;
		}
		else
		{
			isHit = false;
		}
    }

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("In " + other.gameObject.name);
		hitObjects.Add(other.gameObject);
	}

	private void OnTriggerExit(Collider other)
	{
		Debug.Log("Out " + other.gameObject.name);
		hitObjects.Remove(other.gameObject);
	}

}
