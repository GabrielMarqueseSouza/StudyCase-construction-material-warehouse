using System;

namespace Construction_Material_Warehouse_Domain.Classes
{
    public class Supplier
    {
        public int IdFornecedor { get; set; }
        public int NomeFantasiaFornecedor { get; set; }
        public int RazãoSocialFornecedor { get; set; }
        public int Endereço { get; set; }
        public int CodPostal { get; set; }
        public int DscProdutoFornecido { get; set; }
        public int Contato { get; set; }
        public int EmailFornecedor { get; set; }
        public DateTime DataSolicitaçãoProduto { get; set; }
        public int CPFCNPJFornecedor { get; set; }
        public int EntregaProduto { get; set; }
        public int UsuarioInclusãoSistema { get; set; }
        public int IdPermissõesCategoria { get; set; }
    }
}
