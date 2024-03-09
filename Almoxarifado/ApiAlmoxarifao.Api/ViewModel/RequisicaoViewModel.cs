using ApiAlmoxarifao.Api.ViewModel;

namespace APIAlmoxarifado.ViewModel
{
    public class RequisicaoViewModel
    {

        public DateTime DataRequisicao { get; set; }

        public List<ViewModelListaDeRequisicao>? itens { get; set; }
    }
}
