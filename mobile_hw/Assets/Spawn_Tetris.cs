using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Tetris : MonoBehaviour
{
    [SerializeField]
    private GameObject Tetris=null;
    private GameObject Tetris_1Prefab;
    private GameObject Tetris_2Prefab;
    private GameObject Tetris_3Prefab;
    private GameObject Tetris_4Prefab;
    private GameObject Tetris_5Prefab;

    private float timer = 0.0f;
    private float speed = 0.0f;
    public float speed2 = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3.0f)
        {
            Spawn();
            timer = 0.0f;
            speed2 += 0.02f;
            speed += speed2;
        
        }


        //한 줄이 차면 삭제하는 함수를 만들어야 하는데.. 범위 설정 함수를 모르겠습니다.. 자동으로.. 점수 추가도 못하고 있습니다..
      
        
    }

    private void Spawn()
    {

        Random.Range(1, 5);
        if (Random.Range(1, 5)==1)
        {
            Tetris= Tetris_1Prefab;
        }
        else if (Random.Range(1, 5) == 2)
        {
            Tetris = Tetris_2Prefab;
        }
        else if (Random.Range(1, 5) == 3)
        {
            Tetris = Tetris_3Prefab;
        }
        else if (Random.Range(1, 5) == 4)
        {
            Tetris = Tetris_4Prefab;
        }
        else if (Random.Range(1, 5) == 5)
        {
            Tetris = Tetris_5Prefab;
        }

        

        Vector3 pos = new Vector3(0, 40, 0);
        Instantiate(Tetris, pos, Quaternion.identity);


    }

    void Move()
    {
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            speed = 3.0f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation=Quaternion.Euler(90, 0, 0);
        }

        else if(Input.GetKey(KeyCode.Space))
        {
            speed = 30.0f;
        }
    }
}
