using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunController : MonoBehaviour
{
    [SerializeField] private Gun gun;
    private float roundsInClip;
    private bool isReloading;
    private float reloadTimeElapsed;
    public UnityEvent<Gun> GunFire;
    public UnityEvent<Gun> GunReloading;
    public UnityEvent<Gun> GunReloadFinished;
    private void Awake()
    {
        roundsInClip = gun.RoundsPerClip;
    }

    private void OnEnable()
    {
        isReloading = false;
    }

    private void OnDisable()
    {
        reloadTimeElapsed = 0f;
    }

    public void PullTrigger()
    {
        if (roundsInClip > 0 && !isReloading)
        {
            roundsInClip--;
            GunFire.Invoke(gun);
        }
    }

    public void Reload()
    {
        if (!isReloading)
        {
            isReloading = true;
            GunReloading.Invoke(gun);
        }
    }

    private void FinishReload()
    {
        isReloading = false;
        reloadTimeElapsed = 0f;
        GunReloadFinished.Invoke(gun);
    }

    private void Update()
    {
        if (isReloading)
        {
            reloadTimeElapsed += Time.deltaTime;
            if (reloadTimeElapsed >= gun.ReloadTime)
            {
                FinishReload();
            }
        }
    }
}
