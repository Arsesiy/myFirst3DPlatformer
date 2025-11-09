using TMPro;
using UnityEngine;

public class LifesManager : MonoBehaviour
{
    public TextMeshProUGUI lifesText;
    public int currentLifes = 3;

    public bool IsAlive => currentLifes > 0;

    public void loseLifes()
    {
        if (currentLifes > 0)
        {
            currentLifes--;
            if (currentLifes > 0)
            {
                lifesText.text = lifesText.text.Substring(0, lifesText.text.Length - 1);
            }
            else
            {
                lifesText.text = "";
            }

            if (currentLifes <= 0)
            {
                Debug.Log("ТЫ сдох!");
            }
                
        }
    }

}
