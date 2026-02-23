using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrouchIndicatorGameController : gameuiHUDGameController
	{
		private inkImageWidgetReference _crouchIcon;
		private CName _genderName;
		private CHandle<redCallbackObject> _psmLocomotionStateChangedCallback;

		[Ordinal(9)] 
		[RED("crouchIcon")] 
		public inkImageWidgetReference CrouchIcon
		{
			get => GetProperty(ref _crouchIcon);
			set => SetProperty(ref _crouchIcon, value);
		}

		[Ordinal(10)] 
		[RED("genderName")] 
		public CName GenderName
		{
			get => GetProperty(ref _genderName);
			set => SetProperty(ref _genderName, value);
		}

		[Ordinal(11)] 
		[RED("psmLocomotionStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmLocomotionStateChangedCallback
		{
			get => GetProperty(ref _psmLocomotionStateChangedCallback);
			set => SetProperty(ref _psmLocomotionStateChangedCallback, value);
		}

		public CrouchIndicatorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
