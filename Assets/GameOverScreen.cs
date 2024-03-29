using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverScreen : MonoBehaviour
{
    [SerializeField] Canvas GameOverCanvas;

    private void Start()
    {
        GameOverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        GameOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}