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
            LoadImage();

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
        }

        public void test()
        {
            // �׽�Ʈ�Դϴ�
            // 123
        }
    }


}