using System.Collections.Generic;

namespace BethanysPieShop.Model
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> AllCategories { get; }
	}
}