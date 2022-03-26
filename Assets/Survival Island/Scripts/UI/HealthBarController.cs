using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private FloatReference startingHealth;

    // Start is called before the first frame update
    private void Start()
    {
        image.fillAmount = 1f;
    }

    public void GainHealth(float healthToGain)
    {
        UpdateHealth(healthToGain);
    }

    public void LoseHealth(float healthToLose)
    {
        // Debug.Log("I lost health");
        UpdateHealth(-healthToLose);
    }

    private void UpdateHealth(float healthChange)
    {
        image.fillAmount += healthChange / startingHealth.Value;
    }
}
