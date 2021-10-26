using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomEffect : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera LanderVCam;
    [SerializeField] Transform TargetGroup;
    [SerializeField] Transform Lander;
    [SerializeField] Transform LanderObjective;
    void Start()
    {
        LanderVCam.Follow = TargetGroup;
        StartCoroutine(changeLanderVCamFollower());
    }

    IEnumerator changeLanderVCamFollower()
    {
        yield return new WaitForSeconds(2);
        TargetGroup.GetComponent<CinemachineTargetGroup>().RemoveMember(LanderObjective);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


