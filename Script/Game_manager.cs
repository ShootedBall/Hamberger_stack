using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour {
    //열거형을 이용해서 버거종류 구성(순서대로 0,1, .. )
    enum bugger
    {
        meat,
        noraml,
        general,
        cheese,
        tomato
    }
    public SpriteRenderer image;
    public SpriteRenderer recipe_image;

    //정적 변수 실행 ( 점수, 라이프 )
    static int score;
    static int life;

    //배열구조를 이용하여 버거리스트를 생성
    public static string[,] bugger_list = new string[5, 6] {
        {"downBun", "patty","SangChu","patty","patty","upBun"},
        {"downBun","tomato","patty","SangChu","tomato","upBun" },
        {"downBun","patty","cheese","SangChu","tomato","upBun" },
        {"downBun","cheese","cheese","patty","cheese","upBun" },
        {"downBun","tomato","tomato","SangChu","tomato","upBun" }
    };




    //다 완성되면 초기화 시켜줘야 하는것들임
    public static string[] goal_bugger_stack = new string[6];
    public static int bugger_number;
    public static int bugger_stack;
    public static string now_bugger_incredi;
    public static string fullName;
    public static string stack;
    public static string bugger_name;


    public Text score_text;
    public Text life_text;
    public Text next_incredi_text;



    // Use this for initialization
    // 점수와 라이프 초기화를 시킨뒤 버거를 생성시킴
    void Start () {
        score = 0;
        life = 3;
        makeBuggerStack();

        Sound_Manager.PlaySound("sd_game_playing_bgm");

		
	}
	
	// Update is called once per frame
	void Update () {

        //스프라이트 이미지 변경을 위한 버거의 이름 초기화 라인
        stack = (bugger_stack).ToString();
        fullName = bugger_name + stack;

        image.sprite = Resources.Load<Sprite>(fullName);
        recipe_image.sprite = Resources.Load<Sprite>(bugger_name);

        score_text.text = (score.ToString());
        life_text.text = "life : " + (life.ToString());
        next_incredi_text.text = "<Next>\n" + (now_bugger_incredi);

    }


    //넘겨준 인자 만큼 스코어 추가
    public static void addScore(int value)
    {
        score += value;
    }

    //넘겨준 인자 만큼 스코어 마이너스
    public static void minusLife(int value)
    {
        life -= value;
        Sound_Manager.PlaySound("sd_life_minus");
        if (life == 0){
            Time.timeScale = 0;
            SceneManager.LoadScene("[gameover_scene]");
        }
    }

    //현재 스코어 리턴
    public static int getScore()
    {
        return score;
    }



    //접시에 재료가 쌓일때 실행되는 함수
    public static void checkBuggerStack(string drop_incredi)
    {
        //만약 재료의 이름이 알맞다면
        if (drop_incredi.Equals(now_bugger_incredi))
        {

            Sound_Manager.PlaySound("sd_dish_perfect");
   
            //재료가 다 쌓였으니 점수 증가 시키고 새로운 버거를 만든다
            if(bugger_stack == 5)
            {
                addScore(10);
                makeBuggerStack();
                
            }

            //아직 버거가 덜 쌓였으면 다음에 쌓아야 할 재료의 값을 가져온다
            else
            {
                now_bugger_incredi = goal_bugger_stack[++bugger_stack];

            }
        }

        //알맞은 재료가 아니면 라이프를 마이너스 시킨다
        else
        {
            minusLife(1);
        }

    }





    //햄버거를 만드는 함수
    public static int makeBuggerStack()
    {

        int number = Random.Range(0, 4);

        //스프라이트 이미지 변경을 위한 버거의 이름 초기화 라인

        if (number == 0)
            bugger_name = "meat_";

        else if (number == 1)
            bugger_name = "normal_";

        else if (number == 2)
            bugger_name = "general_";

        else if (number == 3)
            bugger_name = "cheese_";

        else if (number == 4)
            bugger_name = "tomato_";






        for (int i = 0; i < 6; i++)
            goal_bugger_stack[i] = bugger_list[number,i];

        bugger_number = number;
        bugger_stack = 0;
        now_bugger_incredi = goal_bugger_stack[0];




        return number;

    }







}
