using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioHotkeyController : GenericHotkeyController
	{
		private wCHandle<gameIBlackboard> _vehicleBB;
		private CHandle<redCallbackObject> _vehicleEnterListener;
		private CUInt32 _factListener;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _equalizerAnimProxy;
		private CHandle<inkGameNotificationToken> _pocketRadioToken;
		private CBool _isInDefaultState;

		[Ordinal(25)] 
		[RED("vehicleBB")] 
		public wCHandle<gameIBlackboard> VehicleBB
		{
			get => GetProperty(ref _vehicleBB);
			set => SetProperty(ref _vehicleBB, value);
		}

		[Ordinal(26)] 
		[RED("vehicleEnterListener")] 
		public CHandle<redCallbackObject> VehicleEnterListener
		{
			get => GetProperty(ref _vehicleEnterListener);
			set => SetProperty(ref _vehicleEnterListener, value);
		}

		[Ordinal(27)] 
		[RED("factListener")] 
		public CUInt32 FactListener
		{
			get => GetProperty(ref _factListener);
			set => SetProperty(ref _factListener, value);
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(29)] 
		[RED("equalizerAnimProxy")] 
		public CHandle<inkanimProxy> EqualizerAnimProxy
		{
			get => GetProperty(ref _equalizerAnimProxy);
			set => SetProperty(ref _equalizerAnimProxy, value);
		}

		[Ordinal(30)] 
		[RED("pocketRadioToken")] 
		public CHandle<inkGameNotificationToken> PocketRadioToken
		{
			get => GetProperty(ref _pocketRadioToken);
			set => SetProperty(ref _pocketRadioToken, value);
		}

		[Ordinal(31)] 
		[RED("isInDefaultState")] 
		public CBool IsInDefaultState
		{
			get => GetProperty(ref _isInDefaultState);
			set => SetProperty(ref _isInDefaultState, value);
		}

		public RadioHotkeyController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
