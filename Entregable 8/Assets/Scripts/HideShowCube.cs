using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowCube : MonoBehaviour
{
    public GameObject cube;

    public void hide()
    {
        cube.SetActive(false);
    }

    public void show()
    {
        cube.SetActive(true);
    }
}
