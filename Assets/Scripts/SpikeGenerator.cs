using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject[] bottomSpikes;
    public GameObject[] topSpikes;
    public GameObject[] leftSpikes;
    public GameObject[] rightSpikes;
    // Start is called before the first frame update
    void Start()
    {
        DisableAllSpikes();

        StartCoroutine(ChangeSpikes());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator ChangeSpikes()
    {
        yield return new WaitForSeconds(3);
        DisableAllSpikes();

        //Random Spikes top
        for (int i = 0; i < 10; i++)
        {
            int random = Random.Range(0, 16);
            topSpikes[random].SetActive(true);
        }

        //Random Spikes bottom
        for (int i = 0; i < 10; i++)
        {
            int random = Random.Range(0, 16);
            bottomSpikes[random].SetActive(true);
        }

        //Random Spikes left
        for (int i = 0; i < 3; i++)
        {
            int random = Random.Range(0, 5);
            leftSpikes[random].SetActive(true);
        }

        //Random Spikes right
        for (int i = 0; i < 3; i++)
        {
            int random = Random.Range(0, 5);
            rightSpikes[random].SetActive(true);
        }

        StartCoroutine(ChangeSpikes());
    }

    private void DisableAllSpikes()
    {
        foreach (GameObject bottomSpike in bottomSpikes)
        {
            bottomSpike.SetActive(false);
        }
        foreach (GameObject topSpike in topSpikes)
        {
            topSpike.SetActive(false);
        }
        foreach (GameObject leftSpike in leftSpikes)
        {
            leftSpike.SetActive(false);
        }
        foreach (GameObject rightSpike in rightSpikes)
        {
            rightSpike.SetActive(false);
        }
    }
}
