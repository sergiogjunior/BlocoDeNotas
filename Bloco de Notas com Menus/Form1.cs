namespace Bloco_de_Notas_com_Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbBlocoNotas.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ArquivoAbrir;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.CheckFileExists == true)
            {
                ArquivoAbrir = openFileDialog1.FileName;
                rtbBlocoNotas.Text = File.ReadAllText(ArquivoAbrir);
                rtbBlocoNotas.Focus();
            }

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\Bloco_Notas"))
            {
                Directory.CreateDirectory("C:\\Bloco_Notas");
                MessageBox.Show("O Diretório foi criado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string NomeArquivo;

            NomeArquivo = "C:\\Bloco_Notas\\Bloco de Notas.txt";

            File.AppendAllText(NomeArquivo, rtbBlocoNotas.Text);

            MessageBox.Show("O arquivo foi salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja sair do programa?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }


        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbBlocoNotas.SelectedText);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbBlocoNotas.Text = rtbBlocoNotas.Text + Clipboard.GetText();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }
    }
}