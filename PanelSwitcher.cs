using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    private bool isPanel1Active = true;

    public void SwitchPanels()
    {
        if (isPanel1Active)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            isPanel1Active = false;
        }
        else
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
            isPanel1Active = true;
        }
    }
}