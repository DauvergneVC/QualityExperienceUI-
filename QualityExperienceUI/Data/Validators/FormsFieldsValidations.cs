using AntDesign;
using System.ComponentModel.DataAnnotations;


namespace QualityExperienceUI.Data.Validators
{
    public static class FormValidationRules
    {
        public static FormValidationRule[] idRules = new FormValidationRule[]
        {
            new FormValidationRule{ Required = true, Message = "Campo numerico requerido."},
            new FormValidationRule{ Min = 1, Message = "Id no puede ser 0 o menor."}
        };

        public static FormValidationRule[] numericRules = new FormValidationRule[]
        {
            new FormValidationRule{ Required = true, Message = "Campo numerico requerido."},
            new FormValidationRule{ Min = 0, Message = "Id no puede ser menor a 0."}
        };

        public static FormValidationRule[] textRules = new FormValidationRule[]
        {
            new FormValidationRule{ Type = FormFieldType.String, Required = true, Message = "Campo requerido."},
            new FormValidationRule{ Min=5, Message="Largo minimo del texto = 5"}
        };

        public static FormValidationRule[] selectRules = new FormValidationRule[]
        {
            new FormValidationRule{Required = true, Message = "Seleccione una opcion."},
            new FormValidationRule{ Validator = (context) =>
            {
                if (context.Value is int intValue && intValue == 0 || string.IsNullOrEmpty(context.Value?.ToString()))
                    {
                        return new ValidationResult("Seleccione una opcion válida.", new[] { context.FieldName });
                    }
                    return ValidationResult.Success;
            }
            }
        };
    }
}
