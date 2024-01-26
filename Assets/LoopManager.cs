using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class LoopManager : MonoBehaviour
{
    public List<SCO_Client> clients = new List<SCO_Client>();
    SCO_Client currentClient;

    public SCO_Client SelectClient()
    {
        List<SCO_Client> clientSelected = new List<SCO_Client>();

        for (int i = 0; i < clients.Count; i++)
        {
            if (PlayerReputation.Instance.HasValideReputation(clients[i].reputationMinMax)) clientSelected.Add(clients[i]);
        }

        return clientSelected[Random.Range(0, clientSelected.Count)];
    }
    //clientEnter();
    //gameplayphase()
    //{
    //    // le joueur doit faire une recette � partir des indications du client
    //    // le joueur fais ses m�langes, puis clic sur le bouton "M�langer" pour valider la recette, et on passe � la suite
    //    // Verification si la recette du joueur correspond � la recette du client
    //}

    //exitphase()
    //{
    //    // s�lection du sprite correspond � la r�ussite de la recette ou pas
    //}
}