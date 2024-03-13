using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaveCube : MonoBehaviour
{
    public bool triggerBox;
    MeshRenderer rend;
    public float parameterValue;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerBox)
        {
            Debug.Log("Trigger box was pressed");
            triggerBox = false;
            rend.material.color = GenerateRandomColor();
            MoveUp(parameterValue);
        }
    }

    Color GenerateRandomColor()
    {
        return Random.ColorHSV();
    }

    void MoveUp(float passedValue)
    {
        transform.position += Vector3.up * passedValue;
    }
}
