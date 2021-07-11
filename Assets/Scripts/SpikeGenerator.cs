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

        Debug.Log("Teste");
        DisableAllSpikes();
        ChangeSpikesTopOrBottom(bottomSpikes);
        ChangeSpikesTopOrBottom(topSpikes);
        ChangeSpikesRightOrLeft(leftSpikes);
        ChangeSpikesRightOrLeft(rightSpikes);

        StartCoroutine(ChangeSpikes());
    }

    private void ChangeSpikesTopOrBottom(GameObject[] objArray)
    {
        int min = 0;
        int max = 16;
        int[] randomSpikes = new int[8];

        int i = 0;
        while (i < 8)
        {
            int randomNumber = Random.Range(min, max);
            if (randomSpikes.Contains<int>(randomNumber))
            {
                randomSpikes[i] = randomNumber;
                i++;
            }
        }

        foreach (int spike in randomSpikes)
        {
            objArray[spike].SetActive(true);
        }
    }

    private void ChangeSpikesRightOrLeft(GameObject[] objArray)
    {
        int min = 0;
        int max = 6;
        int[] randomSpikes = new int[4];

        int i = 0;
        while (i < 4)
        {
            int randomNumber = Random.Range(min, max);
            if (randomSpikes.Contains<int>(randomNumber))
            {
                randomSpikes[i] = randomNumber;
                i++;
            }
        }

        foreach (int spike in randomSpikes)
        {
            objArray[spike].SetActive(true);
        }
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
