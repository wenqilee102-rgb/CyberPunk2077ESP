using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDriverCombatContextDecisions : InputContextTransitionDecisions
	{
		private CHandle<redCallbackObject> _callbackID;
		private CHandle<redCallbackObject> _tppCallbackID;
		private CHandle<redCallbackObject> _upperBodyCallbackID;
		private CBool _inTpp;
		private CBool _isAiming;

		[Ordinal(0)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		[Ordinal(1)] 
		[RED("tppCallbackID")] 
		public CHandle<redCallbackObject> TppCallbackID
		{
			get => GetProperty(ref _tppCallbackID);
			set => SetProperty(ref _tppCallbackID, value);
		}

		[Ordinal(2)] 
		[RED("upperBodyCallbackID")] 
		public CHandle<redCallbackObject> UpperBodyCallbackID
		{
			get => GetProperty(ref _upperBodyCallbackID);
			set => SetProperty(ref _upperBodyCallbackID, value);
		}

		[Ordinal(3)] 
		[RED("inTpp")] 
		public CBool InTpp
		{
			get => GetProperty(ref _inTpp);
			set => SetProperty(ref _inTpp, value);
		}

		[Ordinal(4)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		public VehicleDriverCombatContextDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
