using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDaColors : MonoBehaviour
{
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    private void Start()
    {
        StartCoroutine(ChangeColors());
    }
    IEnumerator ChangeColors()
    {
        while(1 == 1)
        {
            img1.SetActive(true);
            img3.SetActive(false);
            yield return new WaitForSeconds(1);

            img2.SetActive(true);
            img1.SetActive(false);
            yield return new WaitForSeconds(1);

            img3.SetActive(true);
            img2.SetActive(false);
            yield return new WaitForSeconds(1);
        }
        yield return null;
    }
}
