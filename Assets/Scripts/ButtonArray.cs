using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonArray : MonoBehaviour
{
    public Button[] Buttons;
    public Button right;
    public Button left;
    public Canvas Canvas;
    public int SelectedButton = 0;
    public RectTransform rectTransform;
    public float ListLengthMax;
    public float listLengthMin;
    public float PreviousButton;
    public float FollowingButton;
    public float posX = 540;
    public float posY = 240.7f;

    void Start()
    {
        FollowingButton = SelectedButton + 1;
        PreviousButton = SelectedButton - 1;
        SelectedButton = 0;
        InstantiateButton();
    }
    public void InstantiateButton()
    {
        Button currentButton = Buttons[SelectedButton];
        rectTransform = currentButton.GetComponent<RectTransform>();
        currentButton.transform.position = new Vector2(530, 260);
        currentButton.transform.parent = Canvas.transform;
        if (SelectedButton > ListLengthMax)
        {
            Buttons[SelectedButton + 1].transform.parent = null;
        }
        if(SelectedButton > 0) 
        {
            Buttons[SelectedButton - 1].transform.parent = null;
        }
    }
    public void RightButton()
    {
        for (int i = 0; i < 100; i++)
        {
            if (SelectedButton >= ListLengthMax)
            {
                SelectedButton -= 1;
            }
        }
        Button currentButton = Buttons[SelectedButton];
        rectTransform = currentButton.GetComponent<RectTransform>();
        SelectedButton += 1;
        InstantiateButton();
        Debug.Log("List number" + SelectedButton);
    }
    public void LeftButton()
    {
        for (int i = 0; i < 100; i++)
        {
            if (SelectedButton <= 0)
            {
                SelectedButton += 1;
            }
        }
        Button currentButton = Buttons[SelectedButton];
        rectTransform = currentButton.GetComponent<RectTransform>();
        SelectedButton -= 1;
        InstantiateButton();
        Debug.Log("List number" + SelectedButton);
    }
}
