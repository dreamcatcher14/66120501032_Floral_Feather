using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Farming : MonoBehaviour
{
    Collider2D coliider;
    Rigidbody2D rb2d;
    public GameObject PlantButton;
    public GameObject CollectButton;
    public GameObject PlantBox;
    public GameObject PlantStage1;
    public GameObject PlantStage2;
    public GameObject PlantStage3;
    public GameObject Level;

    void Start()
    {
        coliider = GetComponent<Collider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        PlantButton.SetActive(false);
        CollectButton.SetActive(false);
        PlantBox.SetActive(false);
        PlantStage1.SetActive(false);
        PlantStage2.SetActive(false);
        PlantStage3.SetActive(false);
        Level.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlantButton.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlantButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlantButton.SetActive(false);
        }
    }

    public void OnButtonClick()
    {
        PlantBox.SetActive(true);
    }
    public void PlantButtonClick()
    {
        PlantBox.SetActive(false);
        Level.SetActive(true);
        StartCoroutine(GrowPlant());
    }
    IEnumerator GrowPlant()
    {
        PlantStage1.SetActive(true);
        yield return new WaitForSeconds(3);
        PlantStage1.SetActive(false);

        PlantStage2.SetActive(true);
        yield return new WaitForSeconds(3);
        PlantStage2.SetActive(false);

        PlantStage3.SetActive(true);

        CollectButton.SetActive(true);
    }

    public void CollectButtonClick()
    {
        PlantStage3.SetActive(false);
        CollectButton.SetActive(false);
    }
}
