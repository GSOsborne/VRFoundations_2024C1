using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleForever : MonoBehaviour
{
    Vector3 setScale = new Vector3(1, 2, 3);
    public Transform someOtherTransformComponentThatWeCareAbout;
    //VideoPlayer

    // Start is called before the first frame update
    void Start()
    {
        someOtherTransformComponentThatWeCareAbout.localScale = setScale;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ReturnTheBestInteger());
    }

    int ReturnTheBestInteger()
    {
        int randomNumber = Random.Range(0, 100);
        return randomNumber;
    }

}
