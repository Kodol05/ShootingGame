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

        }

        /*
        // �̹����� ȭ�鿡 ����Ҽ��ְ��ϴ� Ŭ����
        void LoadImage()
        {
            try
            {
                // �̹��� ��� ���� (���� ��� �Ǵ� ��� ���)
                string imagePath = "D:\\work\\ShootingGame\\images\\���.png";

                // �̹��� �ε�
                pictureBox1.Image = Image.FromFile(imagePath);

                // �̹��� ũ�⸦ PictureBox�� �°� ����
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                // �̹��� �ε� ���� �� ���� ó��
                MessageBox.Show("�̹����� �ε��ϴ� ���� ������ �߻��߽��ϴ�: " + ex.Message);
            }
        }
        */
        void CollisionDetection()
        {
            // �浹 Ȯ�� �޼��� (������)
        }

        void MoveBackground()
        {
            // ����� �����̴� Ŭ���� (������)
        }

        void PlayerAttack()
        {
            // �÷��̾� �Ϲݰ����� ����ϴ� Ŭ���� (������)
        }

        void PlayerSpecialAttack()
        {
            // �÷��̾��� �������� ����ϴ� Ŭ���� (������)
        }

        void Disapper()
        {
            // ü���� 0�̵ɶ� ������� �ϴ� Ŭ���� (�̱���)
        }

        void EntityInformation()
        {
            // �÷��̾�, ���, ������ ������ ��� Ŭ���� (������)
        }

        void Bosspattern()
        {
            // ���� ������ ����ϴ� Ŭ���� (������)
        }

    }


}