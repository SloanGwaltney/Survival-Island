using UnityEngine;
using UnityEngine.Events;

public class GunController : MonoBehaviour
{
    [SerializeField] private Gun gun;
    private float roundsInClip;
    private bool isReloading;
    private bool isActionCycling;
    private float reloadTimeElapsed;
    private float actionCyclingTimeElapsed;
    public UnityEvent<Gun> GunFire;
    public UnityEvent<Gun> GunReloading;
    public UnityEvent<Gun> GunReloadFinished;
    public UnityEvent<Gun> ActionCyclingStarted;
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
        isReloading = false;
        isActionCycling = false;
    }

    public void PullTrigger()
    {
        if (roundsInClip > 0 && !isReloading && !isActionCycling)
        {
            roundsInClip--;
            GunFire.Invoke(gun);
            if (gun.Action.CycleTime > 0f)
            {
                StartActionCycle();
                GameObject projectile = Instantiate<GameObject>(gun.ProjectilePrefab, transform.forward, transform.rotation);
                Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
                if (!rigidbody) Debug.Log("A gun fired a bullet without a rigidbody");
                rigidbody?.AddForce(transform.forward * gun.ProjectileFireForce, ForceMode.Force);
            }
        }
    }

    public void Reload()
    {
        if (!isReloading && !isActionCycling)
        {
            isReloading = true;
            GunReloading.Invoke(gun);
        }
    }

    protected void FinishReload()
    {
        isReloading = false;
        reloadTimeElapsed = 0f;
        GunReloadFinished.Invoke(gun);
    }

    protected void StartActionCycle()
    {
        ActionCyclingStarted.Invoke(gun);
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
            if (reloadTimeElapsed >= gun.ReloadTime)
            {
                FinishReload();
            }
        }
        if (isActionCycling)
        {
            actionCyclingTimeElapsed += Time.deltaTime;
            if (actionCyclingTimeElapsed >= gun.Action.CycleTime)
            {
                FinishActionCycle();
            }
        }
    }
}
