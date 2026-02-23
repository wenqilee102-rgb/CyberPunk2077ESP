using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Smart_Rifl_Bucket : inkWidgetLogicController
	{
		private CFloat _lockingAnimationLength;
		private CFloat _unlockingAnimationLength;
		private inkWidgetReference _deadEyeWidget;
		private gamesmartGunUITargetParameters _data;
		private CHandle<inkanimProxy> _lockingAnimationProxy;
		private CHandle<inkanimProxy> _unlockingAnimationProxy;
		private CArray<gameDelayID> _activeCallbacks;
		private CBool _hasDeadEye;
		private CHandle<inkanimProxy> _deadEyeAnimProxy;

		[Ordinal(1)] 
		[RED("lockingAnimationLength")] 
		public CFloat LockingAnimationLength
		{
			get => GetProperty(ref _lockingAnimationLength);
			set => SetProperty(ref _lockingAnimationLength, value);
		}

		[Ordinal(2)] 
		[RED("unlockingAnimationLength")] 
		public CFloat UnlockingAnimationLength
		{
			get => GetProperty(ref _unlockingAnimationLength);
			set => SetProperty(ref _unlockingAnimationLength, value);
		}

		[Ordinal(3)] 
		[RED("deadEyeWidget")] 
		public inkWidgetReference DeadEyeWidget
		{
			get => GetProperty(ref _deadEyeWidget);
			set => SetProperty(ref _deadEyeWidget, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public gamesmartGunUITargetParameters Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetProperty(ref _lockingAnimationProxy);
			set => SetProperty(ref _lockingAnimationProxy, value);
		}

		[Ordinal(6)] 
		[RED("unlockingAnimationProxy")] 
		public CHandle<inkanimProxy> UnlockingAnimationProxy
		{
			get => GetProperty(ref _unlockingAnimationProxy);
			set => SetProperty(ref _unlockingAnimationProxy, value);
		}

		[Ordinal(7)] 
		[RED("activeCallbacks")] 
		public CArray<gameDelayID> ActiveCallbacks
		{
			get => GetProperty(ref _activeCallbacks);
			set => SetProperty(ref _activeCallbacks, value);
		}

		[Ordinal(8)] 
		[RED("hasDeadEye")] 
		public CBool HasDeadEye
		{
			get => GetProperty(ref _hasDeadEye);
			set => SetProperty(ref _hasDeadEye, value);
		}

		[Ordinal(9)] 
		[RED("deadEyeAnimProxy")] 
		public CHandle<inkanimProxy> DeadEyeAnimProxy
		{
			get => GetProperty(ref _deadEyeAnimProxy);
			set => SetProperty(ref _deadEyeAnimProxy, value);
		}

		public Crosshair_Smart_Rifl_Bucket(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
