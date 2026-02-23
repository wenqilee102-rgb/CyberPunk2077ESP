using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorClose : ActionBool
	{
		private CName _slotID;
		private CBool _isInteractionSource;
		private CBool _forceScene;

		[Ordinal(39)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(40)] 
		[RED("isInteractionSource")] 
		public CBool IsInteractionSource
		{
			get => GetProperty(ref _isInteractionSource);
			set => SetProperty(ref _isInteractionSource, value);
		}

		[Ordinal(41)] 
		[RED("forceScene")] 
		public CBool ForceScene
		{
			get => GetProperty(ref _forceScene);
			set => SetProperty(ref _forceScene, value);
		}

		public VehicleDoorClose(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
