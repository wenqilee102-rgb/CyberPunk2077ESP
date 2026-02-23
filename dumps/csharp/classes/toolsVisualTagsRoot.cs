using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsVisualTagsRoot : ISerializable
	{
		private CArray<toolsVisualTagsSchema> _schemas;

		[Ordinal(0)] 
		[RED("schemas")] 
		public CArray<toolsVisualTagsSchema> Schemas
		{
			get => GetProperty(ref _schemas);
			set => SetProperty(ref _schemas, value);
		}

		public toolsVisualTagsRoot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
