using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Triangle0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {

            LabelResult.Text = string.Empty;
            bool flagA = double.TryParse(ABox.Text, out double a);
            if (!flagA)
            {
                LabelResult.Text = "�� �� ����� �������� ������� � ���� ����� �� �����!";
                ABox.Text = string.Empty;
                BBox.Text = string.Empty;
                CBox.Text = string.Empty;
                return;

            }
            bool flagB = double.TryParse(BBox.Text, out double b);
            if (!flagB)
            {
                LabelResult.Text = "�� �� ����� �������� ������� B ���� ����� �� �����";
                ABox.Text = string.Empty;
                BBox.Text = string.Empty;
                CBox.Text = string.Empty;
                return;

            }
            bool flagC = double.TryParse(CBox.Text, out double c);
            if (!flagC)
            {
                LabelResult.Text = "�� �� ����� �������� ������� C ���� ����� �� �����";
                ABox.Text = string.Empty;
                BBox.Text = string.Empty;
                CBox.Text = string.Empty;
                return;

            }
            if (a <= 0 || c <= 0 || b <= 0)
            {
                LabelResult.Text = "�� ������� �������, ������� ������ ���� ����� 0!";
                ABox.Text = string.Empty;
                BBox.Text = string.Empty;
                CBox.Text = string.Empty;
                return;
            }


            if (a + b <= c || a + c <= b || b + c <= a)
            {
                LabelResult.Text = "���� ������� ������ ����� ���� ������ ��� ����� ��!";
                ABox.Text = string.Empty;
                BBox.Text = string.Empty;
                CBox.Text = string.Empty;
                return;
            }
            if (a > 1000000 || b > 1000000 || c > 1000000)
            {
                LabelResult.Text = "�� �����re ������� ������� �����!";
                ABox.Text = string.Empty;
                BBox.Text = string.Empty;
                CBox.Text = string.Empty;
                return;
            }


            if (a == b & b == c)
            {
                LabelResult.Text = "��� �������������� �����������";
                return;

            }
            if (a == b || b == c || a == c)
            {
                LabelResult.Text = "��� �������������� �����������";
                return;

            }
            if (a != b & b != c)
            {
                LabelResult.Text = "��� �������������� �����������";
                return;
            }
        }

    }
}