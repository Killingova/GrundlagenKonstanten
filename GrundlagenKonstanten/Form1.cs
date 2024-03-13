namespace GrundlagenKonstanten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private const int MaxWert = 75;
        private const string Eintrag = "Picture";

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            const int MaxWert = 55;
            const int MinWert = 5;
            LblAnzeigen.Text = $"{(MaxWert - MinWert) / 2}\n{Eintrag}";
        }

        private enum Farbe : int    //Enumerationen
        {
            Rot = 1, Gelb = 2, Blau = 3
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = $"Farbe: {Farbe.Gelb} {(int)Farbe.Gelb}";
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text =
                $"Sonntag: {DayOfWeek.Sunday} {(int)DayOfWeek.Sunday}\n" +
                $"Samstag: {DayOfWeek.Saturday} {(int)DayOfWeek.Saturday}";
        }
    }
}
