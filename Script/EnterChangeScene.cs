using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterChangeScene : MonoBehaviour
{
    Collider2D coliider;
    Rigidbody2D rb2d;
    public int SceneIndex;
    public int SceneCount;
    public GameObject enterButton;

    void Start()
    {
        coliider = GetComponent<Collider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        enterButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterButton.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enterButton.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneIndex = scene.buildIndex;
        int sceneIndex = SceneIndex + 1;
        SceneManager.LoadScene(SceneIndex + 1);
        enterButton.SetActive(false);
    }

}
