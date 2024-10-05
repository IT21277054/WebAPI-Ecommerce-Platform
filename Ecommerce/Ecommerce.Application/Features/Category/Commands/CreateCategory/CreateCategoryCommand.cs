using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory;

public class CreateCategoryCommand: IRequest<int>
{
    public string name {  get; set; } = string.Empty;

}
