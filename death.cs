using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        SceneManager.LoadScene("game over");

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
