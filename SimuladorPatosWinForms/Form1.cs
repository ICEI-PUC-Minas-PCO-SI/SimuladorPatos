// Form1.cs
using SimuladorPatosWinForms.Classes;
using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms
{
    public partial class Form1 : Form
    {
        private Duck patoAtual;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string selecionado = comboBoxPatos.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selecionado))
            {
                MessageBox.Show("Por favor, selecione um pato antes de continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            patoAtual = selecionado switch
            {
                "Pato Real" => new MallardDuck(),
                "Pato Cabeça Vermelha" => new RedHeadDuck(),
                "Pato de Borracha" => new RubberDuck(),
                "Pato Carolino" => new WoodenDuck(),
                "Alexandre Pato" => new AlexandrePato(),
                "Irerê" => new Irere(),
                "Pato Mergulhão" => new PatoMergulhao(),
                _ => null
            };

            txtLog.Clear();
            txtLog.AppendText($"🦆 Pato selecionado: {selecionado}\r\n");
            txtLog.AppendText("Habilidades disponíveis:\r\n");

            AtualizarBotoesDeAcao();
        }

        private void btnNadar_Click(object sender, EventArgs e)
        {
            if (patoAtual == null)
            {
                txtLog.AppendText("⚠️ Selecione um pato antes de nadar.\r\n");
                return;
            }

            txtLog.AppendText(patoAtual.Swim() + "\r\n");
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            if (patoAtual == null)
            {
                txtLog.AppendText("⚠️ Selecione um pato antes de voar.\r\n");
                return;
            }

            if (patoAtual is IFlyable f)
                txtLog.AppendText(f.Fly() + "\r\n");
            else
                txtLog.AppendText("❌ Este pato não sabe voar.\r\n");
        }

        private void btnGrasnar_Click(object sender, EventArgs e)
        {
            if (patoAtual == null)
            {
                txtLog.AppendText("⚠️ Selecione um pato antes de tentar grasnar.\r\n");
                return;
            }

            if (patoAtual is IQuackable q)
                txtLog.AppendText(q.Quack() + "\r\n");
            else
                txtLog.AppendText("❌ Este pato não sabe grasnar.\r\n");
        }

        private async void btnChutar_Click(object sender, EventArgs e)
        {
            if (patoAtual == null)
            {
                txtLog.AppendText("⚠️ Selecione um pato antes de tentar chutar.\r\n");
                return;
            }

            if (patoAtual is IKickable k)
            {
                var resultado = k.Kick();
                txtLog.AppendText(resultado + "\r\n");

                if (patoAtual is AlexandrePato)
                {
                    await Task.Delay(1000);
                    txtLog.AppendText("📢 Errooouuuu!\r\n");
                }
            }
            else
            {
                txtLog.AppendText("❌ Este pato não sabe chutar.\r\n");
            }
        }

        private void AtualizarBotoesDeAcao()
        {
            btnVoar.Enabled = patoAtual is IFlyable;
            btnGrasnar.Enabled = patoAtual is IQuackable;
            btnChutar.Enabled = patoAtual is IKickable;

            txtLog.AppendText(patoAtual is IQuackable ? "- Grasnar\r\n" : "");
            txtLog.AppendText(patoAtual is IFlyable ? "- Voar\r\n" : "");
            txtLog.AppendText(patoAtual is IKickable ? "- Chutar\r\n" : "");
            txtLog.AppendText("- Nadar\r\n");
            txtLog.AppendText("\r\nUse os botões à direita para testar as ações.\r\n");
        }

    }
}
