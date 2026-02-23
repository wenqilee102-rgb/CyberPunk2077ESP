using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminaListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CBool _psmAdded;
		private CFloat _staminaValue;
		private CFloat _staminPerc;
		private CFloat _sfxThreshold;
		private CFloat _sfxDelay;
		private CName _sfxName;
		private gameDelayID _delayID;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("psmAdded")] 
		public CBool PsmAdded
		{
			get => GetProperty(ref _psmAdded);
			set => SetProperty(ref _psmAdded, value);
		}

		[Ordinal(2)] 
		[RED("staminaValue")] 
		public CFloat StaminaValue
		{
			get => GetProperty(ref _staminaValue);
			set => SetProperty(ref _staminaValue, value);
		}

		[Ordinal(3)] 
		[RED("staminPerc")] 
		public CFloat StaminPerc
		{
			get => GetProperty(ref _staminPerc);
			set => SetProperty(ref _staminPerc, value);
		}

		[Ordinal(4)] 
		[RED("sfxThreshold")] 
		public CFloat SfxThreshold
		{
			get => GetProperty(ref _sfxThreshold);
			set => SetProperty(ref _sfxThreshold, value);
		}

		[Ordinal(5)] 
		[RED("sfxDelay")] 
		public CFloat SfxDelay
		{
			get => GetProperty(ref _sfxDelay);
			set => SetProperty(ref _sfxDelay, value);
		}

		[Ordinal(6)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetProperty(ref _sfxName);
			set => SetProperty(ref _sfxName, value);
		}

		[Ordinal(7)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		public StaminaListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
