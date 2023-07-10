using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : Interactable
{
    public Transform playerTransform, destinationTP;
    public GameObject player;
    public GameObject teleportPanel;


    void Start()
    {
        teleportPanel.SetActive(false);
    }


    public override void Interact()
    {
        base.Interact();

        PanelOn();
    }


    public void PanelOn()
    {
        teleportPanel.SetActive(true);
    }


    public void PanelOff()
    {
        teleportPanel.SetActive(false);
    }


    public void Teleport()
    {
        player.SetActive(false);
        teleportPanel.SetActive(false);
        playerTransform.position = destinationTP.position;
        player.SetActive(true);
    }
}
