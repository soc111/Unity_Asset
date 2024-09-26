using UnityEngine;
public class ChangeColorScript : MonoBehaviour
{
    // Method to change the color
    public void ChangeColor()
    {
        // Generate a random color
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        // Apply the color to this object's material
        GetComponent<Renderer>().material.color = randomColor;
    }

}