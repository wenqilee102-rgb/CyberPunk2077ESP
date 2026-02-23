using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsVisualTagsSchema : ISerializable
	{
		private CName _name;
		private CArray<toolsVisualTagsGroup> _categories;
		private CArray<toolsVisualTagsGroup> _presets;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("categories")] 
		public CArray<toolsVisualTagsGroup> Categories
		{
			get => GetProperty(ref _categories);
			set => SetProperty(ref _categories, value);
		}

		[Ordinal(2)] 
		[RED("presets")] 
		public CArray<toolsVisualTagsGroup> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}

		public toolsVisualTagsSchema(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
