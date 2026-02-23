using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterButtonSpawnedData : IScriptable
	{
		private CInt32 _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public FilterButtonSpawnedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
