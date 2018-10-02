using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public List<GameObject> Objects;

    private void Start()
    {
        int whichObject = Random.Range(0, Objects.Count);
        Instantiate(Objects[whichObject], transform.position, Objects[whichObject].transform.rotation);
    }
}
