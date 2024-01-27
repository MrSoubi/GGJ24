using TMPro;
using UnityEngine;

public class PlayerReputation : MonoBehaviour
{
    public int reputation = 5;

    public TMP_Text reputationTxt;

    private static PlayerReputation instance = null;
    public static PlayerReputation Instance => instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        reputationTxt.text = "Reputation : " + reputation;
    }

    public void AddReputation(int reputationToAdd)
    {
        reputation += reputationToAdd;
        reputationTxt.text = "Reputation : " + reputation;
    }
    public void RemoveReputation(int reputationToRemove)
    {
        reputation -= reputationToRemove;
        reputationTxt.text = "Reputation : " + reputation;
    }

    // Moved to the function CanEnterTheShop directly on the Client class.
    /*
    public bool HasValideReputation(Vector2 minMaxReputationRequire)
    {
        if (reputation >= minMaxReputationRequire.x && reputation <= minMaxReputationRequire.y)
        {
            return true;
        }
        else return false;
    }
    */
}
