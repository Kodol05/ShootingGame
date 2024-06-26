using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShootingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 메인 클래스입니다 테스트용으로 아래에 코드를 써도 괜찮습니다
            // 혹시나  조심해주세요
            // test
            // 123

            
        }

        void GameStart(){// 게임 시작 화면을 나타내는 클래스(김현민)}
        void GameOver(){// 게임 오버화면 몇초뒤 게임시작 화면으로 넘어간다 (김현민)}
        void GameEnd(){// 게임의 엔딩(클리어)를 화면에 나타내는 클래스 (김현민)}

        void ShowInfo()
        {
            // HP, SP_item, attack_stage를 단순 글씨가아닌 이미지를 통해서 보여준다. (김현민)
        }
        void CollisionDetection()
        {
            // 충돌 확인 메서드 (김현민)
        }

        void MainTimer()
        {
            // 모두 다다르게 타이머를 돌릴수도있지만 작업을 줄이기위해서 최대한 타이머 한개로 통일하여 진행. 메인타이머 (김현민)
        }
        
        void MoveBackground()
        {
            // 배경을 움직이는 클래스 (이지원)
            // 아래 주석은 참고만해주세요 무조건적으로 따라하실필요는 없습니다
            // 타이머 컨트롤을 통해서 예시 30ms마다 이동하도록 설정
            // 30ms 마다 배경(picturebox)을 아래쪽으로 이동하게 합니다
            // 화면에 이미지가 끊기지않기위해서 일정 시간마다 새로운 배경을 위에 추가하거나 아래 배경을 위로올립니다
            // 만약 배경을 위로올리는방식말고 위로 새로 추가하는 방식을 선택한다면 계속해서 아래에 picturebox가 쌓이지않도록 삭제를 해야합니다
        }

        void PlayerAttack(int attack_stage)
        {
            // 플레이어 일반공격을 담당하는 클래스 (남준혁)
            // 아래 주석은 참고만해주세요 무조건적으로 따라하실필요는 없습니다
            // 공격은 스페이스바를 통해서 공격을할수있습니다
            // 플레이어의 공격은 4단계로 구성되어있습니다
            // 공격 단계는 매개변수 attack_stage를 통해서 받아서 단계에 맞는공격을 발사한다. (이름변경해도 괜찮고 아에 공격 단계말고 아이템을 먹을때마다 한단계씩 추가해도 괜찮습니다)
            // 1단계 공격(기본공격) : 앞으로 한개의 총알만 발사합니다
            // 2단계 공격(아이템을 한개먹음) : 앞으로 한개의 총알을 발사합니다 좌우대각선으로 총알을 추가적으로 발사한다.
            // 3단계 공격(아이템을 두개먹음) : 앞으로 두개의 총알을 발사하고 좌우 대각선으로 총알을 추가적으로 발사한다.
            // 4단계 공격(아이템을 세개먹음) : 최종단계로 앞으로 세개의 총알을 발사하고 좌우 대각선으로 총알을 추가적으로 발사한다.
            // 4단계가 최종 단계이며 총알은 좌우대각선 정면공격 이미지를 따로 만들어뒀습니다
            // 해당클래스는 단계에따라 switch case문을 사용해서 단계에 따라 다른공격을 할수있게합니다
            // 해당클래스도 타이머를 이용해서 시간마다 정면 총알은 정면쪽으로만 좌우대각선 탄환은 시간에따라 해당 방향에 맞는 방향으로 쭉가는 방식으로 만들면됩니다
            // 대각선 탄환은 약 45도 각도로 도트를 그려놨습니다
            // 공격이 picturebox를 통해서 잘나가는것까지만 확인해주시면 됩니다
            // 공격의 충돌감지는 나중에 충돌감지 완성된다면 해당부분과 확인해서 잘작동하게 만들겠습니다
        }

        void PlayerSpecialAttack(int Sp_Item)
        {
            // 플레이어의 툭수공격을 담당하는 클래스 (남준혁)
            // 아래 주석은 참고만해주세요 무조건적으로 따라하실필요는 없습니다
            // 플레이어의 스페셜아이템(Sp_Item)을 한개 소비하여 일정시간 약10초동안 기본공격을 반달모양공격으로 바꿉니다
            // 10초가 지나간다면 다시 원래 단계의 일반공격으로 돌아오게되며 스페셜아이템(Sp_Item)의 갯수를 한개 줄입니다
        }

        void PlayerMove() // 이교현
        {
             private void Form1_KeyDown(object sender, KeyEventArgs e)
             {
                 PlayerMove(e);
             }

         private void PlayerMove(KeyEventArgs e)
        {
             int newX = player.Location.X;
             int newY = player.Location.Y;

             // WASD와 화살표 키 감지
        switch (e.KeyCode)
             {
                 case Keys.W:
                 case Keys.Up:
                 newY -= moveSpeed;
                 break;
        case Keys.S:
        case Keys.Down:
             newY += moveSpeed;
             break;
        case Keys.A:
        case Keys.Left:
             newX -= moveSpeed;
             break;
        case Keys.D:
        case Keys.Right:
             newX += moveSpeed;
             break;
     }

     // 이동 범위 제한
     if (newX < 0) newX = 0;
     if (newY < 0) newY = 0;
     if (newX > this.ClientSize.Width - player.Width) newX = this.ClientSize.Width - player.Width;
     if (newY > this.ClientSize.Height - player.Height) newY = this.ClientSize.Height - player.Height;

     player.Location = new Point(newX, newY);
     }

        private void Form1_Load(object sender, EventArgs e)
        {
             this.ActiveControl = player;
        }
    }

        void Disapper()
        {
            // 체력이 0이될때 사라지게 하는 클래스 (이교현)
            // 아래 주석은 참고만해주세요 무조건적으로 따라하실필요는 없습니다
            // 해당 객체의 체력이 0이 된다면 아에 삭제해버리면됩니다.
            if (playerHP <= 0)
        {
        // 플레이어의 체력이 0 이하이면 사라지도록 처리
        Disapper();
            }
        }

        void EntityInformation()
        {
            // 플레이어, 잡몹, 보스의 정보를 담는 클래스 (이지원)
            // 해당 클래스를 상속을 통해서 짜야합니다
            
            // Entity클래스 가장 높은 부모클래스
            // 필요한 내용 : int HP(체력), int SNum(고유번호), boolean Invincible(무적여부), boolean Poison(독 여부)
            // Entity를 상속하는 자식클래스
            // Player 클래스 
            // 필요한 내용 : int attack_stage(공격단계), int SP_Item(스페셜 아이템)
            // Mob 클래스
            // 필요한 내용 : int mob_type(몹 타입 종류가 3종류가있기때문에 기입), 
            // Boss 클래스
            // 필요한 내용 : int phase(보스의 페이즈 1,2,3까지 페이즈가 나눠져있기때문에 구성)
            // 내용이 추가될수있습니다

        }

        void Mob_Ant()
        {
            // 몹(개미)을 담당하는 클래스 (김현민)
        }

        void Mob_Mogi()
        {
            // 몹(모기)을 담당하는 클래스 (김현민)
        }

        void Mob_DragonFly()
        {
            // 몹(잠자리)을 담당하는 클래스 (김현민)
        }

        void Drop_Item(int itemPer[])
        {
            // 아이템을 떨어트리는 클래스 (김현민)
            // 몹마다 다른 확률로 아이템을 떨어트리기때문에 확률을 매개변수로 받아서 아이템을 떨어트리게한다
        }
        
        void Bosspattern()
        {
            // 보스 패턴을 담당하는 클래스 (김현민)
        }
        
    }
}
