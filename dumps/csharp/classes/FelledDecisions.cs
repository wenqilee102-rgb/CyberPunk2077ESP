using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FelledDecisions : LocomotionGroundDecisions
	{
		private CBool _felled;
		private CArray<CHandle<redCallbackObject>> _callbackIDs;

		[Ordinal(3)] 
		[RED("felled")] 
		public CBool Felled
		{
			get => GetProperty(ref _felled);
			set => SetProperty(ref _felled, value);
		}

		[Ordinal(4)] 
		[RED("callbackIDs")] 
		public CArray<CHandle<redCallbackObject>> CallbackIDs
		{
			get => GetProperty(ref _callbackIDs);
			set => SetProperty(ref _callbackIDs, value);
		}

		public FelledDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
