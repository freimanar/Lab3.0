using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Redcode.Extensions;
using UnityEngine.SceneManagement;
public class Script : MonoBehaviour
{

    void Update()   
    {
        if (Input.GetKey(KeyCode.W))
        {
           transform.SetPositionZ(transform.position.z + 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.SetPositionZ(transform.position.z - 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.SetPositionX(transform.position.x + 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.SetPositionX(transform.position.x - 7f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
