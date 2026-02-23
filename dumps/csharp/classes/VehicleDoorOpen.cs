using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorOpen : ActionBool
	{
		private CName _slotID;
		private CBool _shouldAutoClose;
		private CFloat _autoCloseTime;
		private CBool _forceScene;

		[Ordinal(39)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(40)] 
		[RED("shouldAutoClose")] 
		public CBool ShouldAutoClose
		{
			get => GetProperty(ref _shouldAutoClose);
			set => SetProperty(ref _shouldAutoClose, value);
		}

		[Ordinal(41)] 
		[RED("autoCloseTime")] 
		public CFloat AutoCloseTime
		{
			get => GetProperty(ref _autoCloseTime);
			set => SetProperty(ref _autoCloseTime, value);
		}

		[Ordinal(42)] 
		[RED("forceScene")] 
		public CBool ForceScene
		{
			get => GetProperty(ref _forceScene);
			set => SetProperty(ref _forceScene, value);
		}

		public VehicleDoorOpen(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
