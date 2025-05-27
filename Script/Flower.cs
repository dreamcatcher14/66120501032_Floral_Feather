using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Flower : MonoBehaviour
{
    Collider2D coliider;
    Rigidbody2D rb2d;
    public GameObject flowerselectpic;
    public TextMeshProUGUI amountText;
    public int amount;

    void Start()
    {
        coliider = GetComponent<Collider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        flowerselectpic.SetActive(false);
        UpdateAmountText();
    }
    public void SelectClick()
    {
        flowerselectpic.SetActive(true);
        amount--;
        if (amount < 0) amount = 0;
        UpdateAmountText();
    }
    public void UpdateAmountText()
    {
        amountText.text = amount.ToString("00");
    }
}
