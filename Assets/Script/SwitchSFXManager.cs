using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSFXManager : MonoBehaviour
{
    public GameObject sfxAudioSource;

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
