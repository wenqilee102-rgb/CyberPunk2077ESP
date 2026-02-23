using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BunkerMapObject : gameObject
	{
		private CInt32 _mapIndex;

		[Ordinal(36)] 
		[RED("mapIndex")] 
		public CInt32 MapIndex
		{
			get => GetProperty(ref _mapIndex);
			set => SetProperty(ref _mapIndex, value);
		}

		public BunkerMapObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
