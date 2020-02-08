using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material material1;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().material = material1;
        Debug.Log("Start called for " + name);

    }

    void Awake()
    {
        Debug.Log("Awake called for " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
