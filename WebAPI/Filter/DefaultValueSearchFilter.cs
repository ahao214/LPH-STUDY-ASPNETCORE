using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebAPI.Filter
{
    /// <summary>
    /// 过滤器
    /// </summary>
    public class DefaultValueSearchFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema == null)
            {
                return;
            }
            var objectSchema = schema;
            foreach (var property in objectSchema.Properties)
            {
                if (property.Value.Type == "string" && property.Value.Default == null)
                {
                    property.Value.Default = new OpenApiString("");
                }
            }


        }
    }
}
