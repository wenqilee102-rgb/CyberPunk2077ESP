using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsVisualTagsGroup : ISerializable
	{
		private CName _name;
		private CArray<toolsVisualTagsDefinition> _tags;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<toolsVisualTagsDefinition> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		public toolsVisualTagsGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
