using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Player Death Test");
        }
    }
}