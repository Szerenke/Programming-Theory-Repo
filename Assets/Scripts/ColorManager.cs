using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    public static Color NewColor { get; private set; }
    public List<Button> colorButtons;

    private Sprite buttonSprite;
    private string colorName = "white";

    void Awake()
    {
        GetOriginalButtonSprite();
        NewColor = Color.white;
    }

    void GetOriginalButtonSprite()
    {
        buttonSprite = colorButtons.ElementAt(0).image.sprite;
    }

    public void SetColorRed()
    {
        NewColor = Color.red;
        colorName = "Red";
        SetActiveButton(NewColor);
    }

    public void SetColorBlue()
    {
        NewColor = Color.blue;
        colorName = "Blue";
        SetActiveButton(NewColor);
    }

    public void SetColorGreen()
    {
        NewColor = Color.green;
        colorName = "Green";
        SetActiveButton(NewColor);
    }

    void SetActiveButton(Color color)
    {
        foreach (Button button in colorButtons)
        {
            if (button.name == colorName)
            {
                Debug.Log("Color clicked: " + button.name);
                button.image.sprite = GameObject.Find("CheckmarkSprite").GetComponent<SpriteRenderer>().sprite;

            }
            else
            {
                button.image.sprite = buttonSprite;
            }
        }

    }
}
