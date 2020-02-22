
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data.Entities;
using MyVet.Web.Models;

namespace MyVet.Web.Helpers
{
	public interface ICombosHelper
	{
		IEnumerable<SelectListItem> GetComboPetTypes();
		IEnumerable<SelectListItem> GetComboServiceTypes();
		
	}
}
