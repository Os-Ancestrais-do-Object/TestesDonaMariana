﻿using TestesDonaMariana.Dominio.ModuloQuestao;

namespace TestesDonaMariana.WinApp.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl, ITabelaBase<Questao>
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            gridQuestao.ConfigurarTabelaGrid("Número", "Enunciado", "Reposta");
        }

        public DataGridView DataGridView { get { return gridQuestao; } }

        public void AtualizarLista(List<Questao> questoes)
        {
            gridQuestao.Rows.Clear();

            foreach (Questao item in questoes)
            {
                DataGridViewRow row = new();

                row.CreateCells(gridQuestao, item.Id, item.Enunciado, item.AlternativaCorreta);

                row.Cells[0].Tag = item;

                gridQuestao.Rows.Add(row);
            }

            TelaPrincipalForm.AtualizarStatus($"Visualizando {questoes.Count} Questões");
        }

        public Questao? ObterRegistroSelecionado()
        {
            return (Questao)gridQuestao.SelectedRows[0].Cells[0].Tag;
        }
    }
}
