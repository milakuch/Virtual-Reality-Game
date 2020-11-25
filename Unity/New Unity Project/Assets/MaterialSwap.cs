using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialSwap : MonoBehaviour
{

    public Material Material1;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;


    public void Start() { }

    public void Swap()
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
    }
}