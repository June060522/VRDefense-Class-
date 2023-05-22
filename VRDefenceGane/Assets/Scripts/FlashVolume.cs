using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FlashVolume : MonoBehaviour
{
    private Volume target;

    private void Awake()
    {
        target = GetComponent<Volume>();
    }

    public void Call()
    {
        StopAllCoroutines();
        StartCoroutine(Process());
    }

    private IEnumerator Process()
    {
        target.enabled = true;
        yield return new WaitForSeconds(0.05f);
        target.enabled = false;
    }
}
