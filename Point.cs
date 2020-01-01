using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Point : MonoBehaviour
{

    public int i = 0;
   public  Text score;
 
    void OnTriggerEnter(Collider other)
    {
        i++;
        if (i == 15)
        {
            //   Destroy(other.gameObject);
            SceneManager.LoadScene("Win");

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        

    }
    private void Update()
    {
        score.text = i.ToString();
    }




}