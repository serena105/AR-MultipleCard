using UnityEngine;

public class GameManager : MonoBehaviour
{
    //2020.10.27
    //public 公開 private私人(預設)
    //定義欄位 (修飾詞 類型 名稱) 
    //2020.11.03
    //Header-標題  語法:[Header("標題名稱")]
    

   [Header("狗")]
   public Transform dog;
   [Header("貓")]
   public Transform cat;
   [Header("虛擬搖桿")]
   public FixedJoystick joystick;
   [Header("Dog旋轉速度"), Range(1f,60f)]
   public float turnD = 1.2f;
   [Header("Cat旋轉速度"), Range(1f, 60f)]
   public float turnC = 1.2f;
   [Header("縮放"), Range(0.01f, 1f)]
   public float size = 0.06f;
   [Header("貓咪動畫元件")]
   public Animator aniCat;
   [Header("狗狗動畫元件")]
   public Animator aniDog;

   //Start  開始事件 
   //print-事件 print("")
   //Update 更新事件 (每個影格執行1次 一秒60影格fps)
   //Vertical 垂直資訊
   //Horizontal 水平資訊
   //Rotate 旋轉 Range (-,-) 範圍限制
   //localScale 縮放

        //public float test1= 1;
        //test1=Mathf.Clamp(test1, 0.5f, 10f);
        //public float test2 = 1;
        //print(Mathf.Clamp(test2, 0, 10));
   
   private void Start()
   {
    print("開始事件");
   }

   private void Update()
   {
    print("更新事件");
    print(joystick.Vertical);

    dog.Rotate(0,  joystick. Horizontal * turnD , 0);
    cat.Rotate(0, joystick. Horizontal*turnC , 0);
    //+=遞增
    dog.localScale += new Vector3 (1, 1, 1) * joystick.Vertical * size;
    dog.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(dog.localScale.x, 0.3f, 3f);
    cat.localScale += new Vector3(1, 1, 1) * joystick.Vertical*size;
    cat.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(cat.localScale.x, 0.3f, 3f);
   }

    //定義方法 Method
    //定義程式區塊1 : 修飾詞 類型 名稱()  {語法}
    //public void attack() {print("攻擊"); aniCAT,SetTrigger(攻擊);}
    //定義程式區塊2 : 修飾詞 類型 名稱(參數1,參數2,.....)  {語法}
    //public void PlayAnimation(string aniName) {print(aniName); aniCat.SetTrigger(aniName); }
    public void PlayAnimation(string aniName)
    {
        print(aniName);
        aniCat.SetTrigger(aniName);
        aniDog.SetTrigger(aniName);
    }

}
