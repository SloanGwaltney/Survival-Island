using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{
    [SerializeField] private FloatReference roundsPerClip;
    [SerializeField] private FloatReference reloadTime;
    [SerializeField] private FloatReference actionCycleTime;
    private float roundsInClip;
    private bool isReloading;
    private bool isActionCycling;
    private float reloadTimeElapsed;
    private float actionCyclingTimeElapsed;
    public UnityEvent GunFire;
    public UnityEvent GunReloading;
    public UnityEvent GunReloadFinished;
    public UnityEvent ActionCyclingStarted;
    private void Awake()
    {
        roundsInClip = roundsPerClip.Value;
    }

    private void OnEnable()
    {
        isReloading = false;
    }

    private void OnDisable()
    {
        reloadTimeElapsed = 0f;
        isReloading = false;
        isActionCycling = false;
    }

    public void PullTrigger(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            PullTrigger();
        }
    }

    public void PullTrigger()
    {
        if (roundsInClip > 0 && !isReloading && !isActionCycling)
        {
            roundsInClip--;
            GunFire.Invoke();
            if (actionCycleTime.Value > 0f)
            {
                StartActionCycle();
            }
        }
    }

    public void Reload()
    {
        if (!isReloading && !isActionCycling)
        {
            isReloading = true;
            GunReloading.Invoke();
        }
    }

    protected void FinishReload()
    {
        isReloading = false;
        reloadTimeElapsed = 0f;
        roundsInClip = roundsPerClip.Value;
        GunReloadFinished.Invoke();
    }

    protected void StartActionCycle()
    {
        ActionCyclingStarted.Invoke();
        isActionCycling = true;
    }

    protected void FinishActionCycle()
    {
        isActionCycling = false;
    }

    private void Update()
    {
        if (isReloading)
        {
            reloadTimeElapsed += Time.deltaTime;
            if (reloadTimeElapsed >= reloadTime.Value)
            {
                FinishReload();
            }
        }
        if (isActionCycling)
        {
            actionCyclingTimeElapsed += Time.deltaTime;
            if (actionCyclingTimeElapsed >= actionCycleTime.Value)
            {
                FinishActionCycle();
            }
        }
    }
}
