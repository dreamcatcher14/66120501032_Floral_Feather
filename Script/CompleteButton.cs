using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompleteButton : MonoBehaviour
{
    public GameObject CompletePopUp;
    private void Start()
    {
        CompletePopUp.SetActive(false);
    }
    public void CompleteButtonClick()
    {
        CompletePopUp.SetActive(true);
    }
}
