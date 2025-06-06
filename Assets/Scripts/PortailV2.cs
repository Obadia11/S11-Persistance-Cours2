using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PortailV2 : MonoBehaviour
{
    public int indexSceneACharger;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Joueur"))
        {
            JeuEspaceV2.instance.ChangerScene(indexSceneACharger);
            JeuEspaceV2.instance.JouerSonPortail();
        }
    }
}
