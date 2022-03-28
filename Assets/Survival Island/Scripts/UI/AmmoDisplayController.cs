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
        ammoText.text = $"{roundsInClip}/{roundsPerClip.Value}";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
