using UnityEngine;

public class Gatherer : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private FloatReference gatherDistance;
    public void Gather()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, gatherDistance.Value))
        {
            GameObject hitObject = hit.collider.gameObject;
            Gatherable gatherableComp = hitObject.GetComponent<Gatherable>();
            if (gatherableComp)
            {
                gatherableComp.Gather();
            }
        }
    }
}
