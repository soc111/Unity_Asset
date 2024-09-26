using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Generate a random color using Random.ColorHSV
        Color randomColor = Random.ColorHSV();
        // Change the material color of the object to the random color
        GetComponent<MeshRenderer>().material.color = randomColor;
    }
}
