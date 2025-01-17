﻿/* By: Ryan Scheppler
* Date: 10/9/19
* Description: Add to object to cause a level change when the player touches it.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ChangeLevelOnCollide : MonoBehaviour
{
    public string NextScene = "EndScene";

    public float changeDelay = 0.2f;

    public UnityEvent OnHit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //run any extra effects
            OnHit.Invoke();
            SceneManager.LoadScene(NextScene);
        }
    }


}
