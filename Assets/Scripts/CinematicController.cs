using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Splines;

public class CinematicController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;

    void Start()
    {
        
    }
    [Button]

    public void SwitchCameras()
    {
        if (camB.Priority  > camA.Priority)
        {
            camB.Priority = 10;
            camA.Priority = 20;
            return;
        }

        else
        {
            camB.Priority = 20;
            camA.Priority = 10;
            return;
        }
    }
}