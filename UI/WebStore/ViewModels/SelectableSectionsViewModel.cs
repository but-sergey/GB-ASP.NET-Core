using System.Collections.Generic;
using WebStore.Domain.ViewModels;

namespace WebStore.ViewModels
{
    public class SelectableSectionsViewModel
    {
        public IEnumerable<SectionViewModel> Sections { get; set; }

        public int? SectionId { get; init; }

        public int? ParentSectionId { get; init; }
    }
}
