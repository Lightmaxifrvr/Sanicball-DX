using System;
using UnityEngine;

public class PCOnlySettingsDisable : MonoBehaviour
{
    public GameObject[] menuopts;

    public void CheckForXbox ()
    {
        if (SystemInfo.deviceType == DeviceType.Console)
        {
            foreach (GameObject obj in menuopts)
            {
                Debug.Log("Removed" + obj.name);
                obj.SetActive(false);

            }

        }

        else { Debug.Log(SystemInfo.deviceType + " (AKA Prolly Not a Console)"); };
    }
}
