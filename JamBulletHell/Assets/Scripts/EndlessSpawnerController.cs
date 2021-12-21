using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawnerController : MonoBehaviour
{

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject spawn6;
    public GameObject spawn7;
    public GameObject spawn8;
    public GameObject spawn9;

    public GameObject player;

    private string tagTemp;
    private int lastPos;

    // Start is called before the first frame update
    void Start()
    {
        ChooseSequence();
    }

    public void ChooseSequence()
    {
        int temp = Random.Range(1, 5);

        print(temp);

        switch (temp)
        {
            case 1:
                StartCoroutine(SequenceOne());
                break;
            case 2:
                StartCoroutine(SequenceTwo());
                break;
            case 3:
                StartCoroutine(SequenceThree());
                break;
            case 4:
                StartCoroutine(SequenceFour());
                break;
        }
    }

    IEnumerator SequenceOne()
    {
        for (int i = 0; i < 101; i++)
        {
            int temp = Random.Range(1, 10);
            if (temp == lastPos)
            {
                temp = temp + 1;
                if (temp > 9)
                {
                    temp = 1;
                }
            }
            lastPos = temp;

            int temp2 = Random.Range(0, 3);

            switch (temp2)
            {
                case 0:
                    tagTemp = "SlowEnemy";
                    break;
                case 1:
                    tagTemp = "FastEnemy";
                    break;
                case 2:
                    tagTemp = "TankEnemy";
                    break;
            }

            switch (temp)
            {
                case 1:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn1.transform.position, spawn1.transform.rotation);
                    break;
                case 2:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn2.transform.position, spawn2.transform.rotation);
                    break;
                case 3:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn3.transform.position, spawn3.transform.rotation);
                    break;
                case 4:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn4.transform.position, spawn4.transform.rotation);
                    break;
                case 5:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn5.transform.position, spawn5.transform.rotation);
                    break;
                case 6:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn6.transform.position, spawn6.transform.rotation);
                    break;
                case 7:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn7.transform.position, spawn7.transform.rotation);
                    break;
                case 8:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn8.transform.position, spawn8.transform.rotation);
                    break;
                case 9:
                    ObjectPooler.Instance.SpawnFromPool(tagTemp, spawn9.transform.position, spawn9.transform.rotation);
                    break;
            }

            yield return new WaitForSeconds(0.3f);
        }

        ChooseSequence();
    }

    IEnumerator SequenceTwo()
    {
        for (int i = 0; i < 21; i++)
        {
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);
            yield return new WaitForSeconds(0.5f);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(1f);

        ChooseSequence();
    }

    IEnumerator SequenceThree()
    {
        for (int i = 0; i < 16; i++)
        {
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);

            yield return new WaitForSeconds(0.5f);

            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);

            yield return new WaitForSeconds(0.5f);

            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);

            yield return new WaitForSeconds(0.5f);

            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);

            yield return new WaitForSeconds(0.5f);

            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);

            if (i > 10)
            {
                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn1.transform.position, spawn1.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn4.transform.position, spawn4.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn7.transform.position, spawn7.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn8.transform.position, spawn8.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn9.transform.position, spawn9.transform.rotation);
            }

            yield return new WaitForSeconds(0.5f);
        }

        ChooseSequence();
    }

    IEnumerator SequenceFour()
    {
        for (int i = 0; i < 21; i++)
        {
            if (i <= 10)
            {
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);

                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn4.transform.position, spawn4.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn8.transform.position, spawn8.transform.rotation);
            }
            else if (i > 10)
            {
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn1.transform.position, spawn1.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn7.transform.position, spawn7.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("TankEnemy", spawn9.transform.position, spawn9.transform.rotation);

                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
            }

            yield return new WaitForSeconds(0.5f);
        }

        ChooseSequence();
    }
}
