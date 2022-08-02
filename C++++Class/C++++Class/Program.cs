using System;

namespace C____Class {
    class Program {
        static int[] Number = new int[3];
        static Random rand = new Random();
        static void Main(string[] args) {
            int Round = 1;
            Setting_Number(); // 숫자 섞기
            for (;;Round++) { // 게임 루프
                Console.WriteLine("라운드 : " + Round);
                Console.Write("확인하고 싶은 숫자 3개를 적으시오. (띄어쓰기 없음, 안적기 없음) : ");
                string Say = Console.ReadLine(), // 숫자 입력
                        Result = Analysis_Player(Say);  // 결과값
                Console.WriteLine(Result + "\n");
                if (Result == "결과 : 정답") break;  // 정답이면 끝내기
            }
            Console.WriteLine("고생하셨습니다. 총 " + Round + "라운드 하셨습니다.");
        }

        static string Analysis_Player(string Say) { // 플레이어 대답 분석
            string Result = "";
            int S_Count = 0, B_Count = 0;
            for (int i = 0; i < 3; i++) for (int j = 0; j < 3; j++) // 분석
                    if (int.Parse(Say[i].ToString()) == Number[j])
                        if (i == j) S_Count++;      // 스트라이크
                        else B_Count++;             // 볼
            // 결과 //
            if (S_Count == 3)                                Result = "결과 : 정답";                                            // 정답
            else if (S_Count == 0 && B_Count == 0) Result = "결과 : 아웃";                                            // 아웃
            else                                                 Result = "결과 : S - " + S_Count + " B - " + B_Count;    // 그 외
            return Result;
        }

        static void Setting_Number() { // 겹치치 않는 3자리 숫자 
            for (int i = 0; i < 3;) {
                Number[i] = rand.Next(0, 10); // 랜덤 숫자
                if (i > 0)
                    if (Number[i] == Number[i - 1] || Number[i] == Number[0]) Number[i] = rand.Next(0, 10); // 이전 값과 같으면 값을 다시 설정
                    else i++;
                else i++;
            }
        }
    }
}
