namespace TutorialAchilles_Core.ViewModels
{
    public class DadosFiltrados
    {
        public dynamic rows { get; set; }
        public int current { get; set; }
        public int rowCount { get; set; }
        public int total { get; set; }

        public DadosFiltrados()
        {
        }

        //public DadosFiltrados(ParametrosPaginacao parametrosPaginacao)
        //{
        //    rowCount = parametrosPaginacao.RowCount;
        //    current = parametrosPaginacao.Current;
        //}
    }
}