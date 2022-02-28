using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleCube : MonoBehaviour
{
    public GameObject cube;
   

    public void ResizeCube(float sizeMultiplier)
    {
        cube.transform.localScale = sizeMultiplier * Vector3.one;
    }
}
