using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeSpawnerController : inkWidgetLogicController
	{
		private CName _objectLibraryID;
		private CUInt32 _initialObjectsCount;

		[Ordinal(1)] 
		[RED("objectLibraryID")] 
		public CName ObjectLibraryID
		{
			get => GetProperty(ref _objectLibraryID);
			set => SetProperty(ref _objectLibraryID, value);
		}

		[Ordinal(2)] 
		[RED("initialObjectsCount")] 
		public CUInt32 InitialObjectsCount
		{
			get => GetProperty(ref _initialObjectsCount);
			set => SetProperty(ref _initialObjectsCount, value);
		}

		public gameuiarcadeArcadeSpawnerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
