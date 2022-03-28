using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplayController : MonoBehaviour
{
    [SerializeField] private FloatReference roundsPerClip;
    [SerializeField] private Text ammoText;
    private float roundsInClip;
    // Start is called before the first frame update
    void Start()
    {
        roundsInClip = roundsPerClip.Value;
        UpdateText();
    }

    public void AmmoConsumed(float amountConsumed)
    {
        roundsInClip -= amountConsumed;
        UpdateText();
    }

    public void Reload(float amountReloaded)
    {
        roundsInClip = amountReloaded;
        UpdateText();
    }

    private void UpdateText()
    {
        ammoText.text = $"{roundsInClip}/{roundsPerClip.Value}";
    }
}
