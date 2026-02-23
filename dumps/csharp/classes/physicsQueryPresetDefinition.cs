using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsQueryPresetDefinition : ISerializable
	{
		private CName _name;
		private CArray<CName> _queryGroups;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("queryGroups")] 
		public CArray<CName> QueryGroups
		{
			get => GetProperty(ref _queryGroups);
			set => SetProperty(ref _queryGroups, value);
		}

		public physicsQueryPresetDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
