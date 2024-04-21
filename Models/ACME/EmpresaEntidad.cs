using System.ComponentModel.DataAnnotations;
namespace Models.ACME
{
    internal class EmpresaEntidad
    {
        [Range (0, int.MaxValue, ErrorMessage = "Debe seleccionar una empresal")]
        [Display(Name = "Codigo")]
        public int IDEmpresa { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public int IDTipoEmpresa { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public string Empresa { get; set; } = string.Empty;
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public string Direccion { get; set; } = string.Empty;
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public string RUC { get; set; } = string.Empty;
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public decimal Presupuesto { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]
        public bool Activo { get; set; } = true;

        //Propiedad de navegacion a TipoEmpresa
        public TipoEmpresaEntidad? TipoEmpresaEntidad { get; set; }
    }
}
