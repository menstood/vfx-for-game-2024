using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayLocator : MonoBehaviour
{
    [SerializeField]
    private GameObject locator1;
    [SerializeField]
    private GameObject locator2;
    [SerializeField]
    private GameObject locator3;
    [SerializeField]
    private GameObject locator4;
    [SerializeField]
    private GameObject locator5;
    [SerializeField]
    private CinemachineVirtualCamera virtualCamera;
    [SerializeField]
    private float delay;


    private CinemachineSmoothPath paths;


    // Start is called before the first frame update
    void Start()
    {


        locator1.SetActive(false);
        locator2.SetActive(false);
        locator3.SetActive(false);
        locator4.SetActive(false);
        locator5.SetActive(false);

        StartCoroutine(DoSchedule());
    }

    IEnumerator DoSchedule()
    {
        var dolly = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition = 0;
        virtualCamera.LookAt = locator1.transform;
        yield return new WaitForSeconds(2);
        SetLocatorActive(locator1);
        yield return new WaitForSeconds(delay);
        dolly.m_PathPosition = 1;
        virtualCamera.LookAt = locator2.transform;
        yield return new WaitForSeconds(2);
        SetLocatorActive(locator2);
        yield return new WaitForSeconds(delay);
        dolly.m_PathPosition = 2;
        virtualCamera.LookAt = locator3.transform;
        yield return new WaitForSeconds(2);
        SetLocatorActive(locator3);
        yield return new WaitForSeconds(delay);
        dolly.m_PathPosition = 3;
        virtualCamera.LookAt = locator4.transform;
        yield return new WaitForSeconds(2);
        SetLocatorActive(locator4);
        yield return new WaitForSeconds(delay);
        dolly.m_PathPosition = 4;
        virtualCamera.LookAt = locator5.transform;
        yield return new WaitForSeconds(2);
        SetLocatorActive(locator5);
    }

    private void SetLocatorActive(GameObject locator)
    {
        locator.SetActive(true);
    }
}