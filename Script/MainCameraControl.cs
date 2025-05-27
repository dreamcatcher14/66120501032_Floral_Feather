using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class MainCameraControl : MonoBehaviour
{
    public GameObject mainCamera, mainCharacter; 
    public GameObject charactherCamera, startCamera; 
    CinemachineBrain cinemachineBrain; 

    void Start()
    {
        cinemachineBrain = mainCamera.GetComponent<CinemachineBrain>();
        mainCharacter.GetComponent<GardenUI>().enabled = false;
        charactherCamera.SetActive(false);
        startCamera.SetActive(true);
        StartCoroutine(MoveCameraToCharacter());
    }
    IEnumerator MoveCameraToCharacter()
    {
        yield return new WaitForSeconds(2);
        charactherCamera.SetActive(true);
        startCamera.SetActive(false);
    }
    void Update()
    {
        if (!cinemachineBrain.IsBlending)
        {
            ICinemachineCamera startCam = startCamera.GetComponent<ICinemachineCamera>();
            bool isStartCamLive = CinemachineCore.Instance.IsLive(startCam);
            if (isStartCamLive)
            {
                mainCharacter.GetComponent<GardenUI>().enabled = true;
            }
        }
    }
}