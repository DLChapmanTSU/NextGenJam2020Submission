using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LevelPhase { FIRST, SECOND, THIRD, FOURTH, FIFTH, SIXTH, SEVENTH }

public class EnemySpawner : MonoBehaviour
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

    //public GameObject staticEnemy;
    //public GameObject quickEnemy;

    //public GameObject[] enemyArray;

    public LevelPhase phase;

    private int lastPos;

    private int lastPhase;

    public GameObject winScreen;

    public GameObject player;

    //public GameObject healthPack;

    private string tagTemp;


    // Start is called before the first frame update
    void Start()
    {
        lastPos = 0;
        lastPhase = 1;
        winScreen.SetActive(false);
        phase = LevelPhase.FIRST;
        StartCoroutine(FirstPhase());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FirstPhase()
    {
        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);

        yield return new WaitForSeconds(2f);

        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);

        yield return new WaitForSeconds(1f);

        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);

        yield return new WaitForSeconds(0.2f);

        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
        ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 21; i++)
        {
            if (i < 11)
            {
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);

                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);

                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);

                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);

                yield return new WaitForSeconds(0.5f);
            }
            else
            {
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);

                yield return new WaitForSeconds(0.5f);

                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);

                yield return new WaitForSeconds(0.5f);
            }
        }

        yield return new WaitForSeconds(0.5f);

        ObjectPooler.Instance.SpawnFromPool("HealthPack", spawn5.transform.position, spawn5.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        phase = LevelPhase.SECOND;
        StartCoroutine(SecondPhase());
    }

    IEnumerator SecondPhase()
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
            print(temp);
            lastPos = temp;

            int temp2 = Random.Range(0, 2);

            switch (temp2)
            {
                case 0:
                    tagTemp = "SlowEnemy";
                    break;
                case 1:
                    tagTemp = "FastEnemy";
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

            
            //if (temp == 1)
            //{
            //    Instantiate(enemyArray[temp2], spawn1.transform.position, spawn1.transform.rotation);
            //}
            //else if (temp == 2)
            //{
            //    Instantiate(enemyArray[temp2], spawn2.transform.position, spawn2.transform.rotation);
            //}
            //else if (temp == 3)
            //{
            //    Instantiate(enemyArray[temp2], spawn3.transform.position, spawn3.transform.rotation);
            //}
            //else if (temp == 4)
            //{
            //    Instantiate(enemyArray[temp2], spawn4.transform.position, spawn4.transform.rotation);
            //}
            //else if (temp == 5)
            //{
            //    Instantiate(enemyArray[temp2], spawn5.transform.position, spawn5.transform.rotation);
            //}
            //else if (temp == 6)
            //{
            //    Instantiate(enemyArray[temp2], spawn6.transform.position, spawn6.transform.rotation);
            //}
            //else if (temp == 7)
            //{
            //    Instantiate(enemyArray[temp2], spawn7.transform.position, spawn7.transform.rotation);
            //}
            //else if (temp == 8)
            //{
            //    Instantiate(enemyArray[temp2], spawn8.transform.position, spawn8.transform.rotation);
            //}
            //else if (temp == 9)
            //{
            //    Instantiate(enemyArray[temp2], spawn9.transform.position, spawn9.transform.rotation);
            //}
            //else
            //{
            //    Instantiate(enemyArray[temp2], spawn5.transform.position, spawn5.transform.rotation);
            //}
            
            yield return new WaitForSeconds(0.3f);
        }

        //if (lastPhase == 1)
        //{
        //    phase = LevelPhase.THIRD;
        //    StartCoroutine(ThirdPhase());
        //}
        //else if (lastPhase == 3)
        //{
        //    phase = LevelPhase.FOURTH;
        //    StartCoroutine(FourthPhase());
        //}
        //else if (lastPhase == 4)
        //{
        //    phase = LevelPhase.FIFTH;
        //    StartCoroutine(FifthPhase());
        //}
        //else if (lastPhase == 5)
        //{
        //    phase = LevelPhase.SIXTH;
        //    StartCoroutine(SixthPhase());
        //}
        //else if (lastPhase == 6)
        //{
        //    phase = LevelPhase.SEVENTH;
        //    StartCoroutine(SeventhPhase());
        //}

        switch (lastPhase)
        {
            case 1:
                phase = LevelPhase.THIRD;
                StartCoroutine(ThirdPhase());
                break;
            case 3:
                phase = LevelPhase.FOURTH;
                StartCoroutine(FourthPhase());
                break;
            case 4:
                phase = LevelPhase.FIFTH;
                StartCoroutine(FifthPhase());
                break;
            case 5:
                phase = LevelPhase.SIXTH;
                StartCoroutine(SixthPhase());
                break;
            case 6:
                phase = LevelPhase.SEVENTH;
                StartCoroutine(SeventhPhase());
                break;
        }
    }

    IEnumerator ThirdPhase()
    {
        lastPhase = 3;
        for (int i = 0; i < 11; i++)
        {
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn9.transform.position, spawn9.transform.rotation);
            if (i > 4)
            {
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
            }
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn8.transform.position, spawn8.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn7.transform.position, spawn7.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn6.transform.position, spawn6.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn5.transform.position, spawn5.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn4.transform.position, spawn4.transform.rotation);
            if (i == 2)
            {
                ObjectPooler.Instance.SpawnFromPool("HealthPack", spawn5.transform.position, spawn5.transform.rotation);
            }
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn3.transform.position, spawn3.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn2.transform.position, spawn2.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn1.transform.position, spawn1.transform.rotation);
            if (i > 4)
            {
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);
            }
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn2.transform.position, spawn2.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn3.transform.position, spawn3.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn4.transform.position, spawn4.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn5.transform.position, spawn5.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn6.transform.position, spawn6.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn7.transform.position, spawn7.transform.rotation);
            yield return new WaitForSeconds(0.3f);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn8.transform.position, spawn8.transform.rotation);
            yield return new WaitForSeconds(0.3f);
        }

        phase = LevelPhase.SECOND;
        StartCoroutine(SecondPhase());
    }

    IEnumerator FourthPhase()
    {
        lastPhase = 4;
        for (int i = 0; i < 21; i++)
        {
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);

            if (i >= 10)
            {
                yield return new WaitForSeconds(1f);

                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn1.transform.position, spawn1.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn2.transform.position, spawn2.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn3.transform.position, spawn3.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn4.transform.position, spawn4.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn5.transform.position, spawn5.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn6.transform.position, spawn6.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn7.transform.position, spawn7.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn8.transform.position, spawn8.transform.rotation);
                ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn9.transform.position, spawn9.transform.rotation);

                yield return new WaitForSeconds(1f);
            }
            else
            {
                yield return new WaitForSeconds(2f);
            }
        }

        ObjectPooler.Instance.SpawnFromPool("HealthPack", spawn5.transform.position, spawn5.transform.rotation);

        phase = LevelPhase.SECOND;
        StartCoroutine(SecondPhase());
    }

    IEnumerator FifthPhase()
    {
        lastPhase = 5;

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

        ObjectPooler.Instance.SpawnFromPool("HealthPack", spawn8.transform.position, spawn8.transform.rotation);

        yield return new WaitForSeconds(1f);

        phase = LevelPhase.SECOND;
        StartCoroutine(SecondPhase());
    }

    IEnumerator SixthPhase()
    {
        lastPhase = 6;

        for (int i = 0; i < 21; i++)
        {
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn1.transform.position, spawn1.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn2.transform.position, spawn2.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn3.transform.position, spawn3.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn4.transform.position, spawn4.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn5.transform.position, spawn5.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn6.transform.position, spawn6.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn7.transform.position, spawn7.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn8.transform.position, spawn8.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn9.transform.position, spawn9.transform.rotation);

            yield return new WaitForSeconds(2f);

            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn1.transform.position, spawn1.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn2.transform.position, spawn2.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn3.transform.position, spawn3.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn4.transform.position, spawn4.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn5.transform.position, spawn5.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn6.transform.position, spawn6.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn7.transform.position, spawn7.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("SlowEnemy", spawn8.transform.position, spawn8.transform.rotation);
            ObjectPooler.Instance.SpawnFromPool("FastEnemy", spawn9.transform.position, spawn9.transform.rotation);

            yield return new WaitForSeconds(2f);
        }

        ObjectPooler.Instance.SpawnFromPool("HealthPack", spawn3.transform.position, spawn3.transform.rotation);

        yield return new WaitForSeconds(1f);

        phase = LevelPhase.SECOND;
        StartCoroutine(SecondPhase());
    }

    IEnumerator SeventhPhase()
    {
        lastPhase = 7;

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

        yield return new WaitForSeconds(5.0f);

        if (player.GetComponent<PlayerController>().isDead == false)
        {
            GameWin();
        }
    }

    public void GameWin()
    {
        int temp = PlayerPrefs.GetInt("Highscore", 0);
        if (player.GetComponent<PlayerController>().points > temp)
        {
            PlayerPrefs.SetInt("Highscore", player.GetComponent<PlayerController>().points);
        }
        winScreen.SetActive(true);
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
