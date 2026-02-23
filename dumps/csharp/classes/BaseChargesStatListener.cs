using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseChargesStatListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CBool _playedCueAlready;
		private CInt32 _currentCharges;
		private CInt32 _currentStatPoolValue;
		private CName _rechargeSoundCue;
		private CHandle<gameStatsSystem> _statSystem;
		private CString _finalString;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("playedCueAlready")] 
		public CBool PlayedCueAlready
		{
			get => GetProperty(ref _playedCueAlready);
			set => SetProperty(ref _playedCueAlready, value);
		}

		[Ordinal(2)] 
		[RED("currentCharges")] 
		public CInt32 CurrentCharges
		{
			get => GetProperty(ref _currentCharges);
			set => SetProperty(ref _currentCharges, value);
		}

		[Ordinal(3)] 
		[RED("currentStatPoolValue")] 
		public CInt32 CurrentStatPoolValue
		{
			get => GetProperty(ref _currentStatPoolValue);
			set => SetProperty(ref _currentStatPoolValue, value);
		}

		[Ordinal(4)] 
		[RED("rechargeSoundCue")] 
		public CName RechargeSoundCue
		{
			get => GetProperty(ref _rechargeSoundCue);
			set => SetProperty(ref _rechargeSoundCue, value);
		}

		[Ordinal(5)] 
		[RED("statSystem")] 
		public CHandle<gameStatsSystem> StatSystem
		{
			get => GetProperty(ref _statSystem);
			set => SetProperty(ref _statSystem, value);
		}

		[Ordinal(6)] 
		[RED("finalString")] 
		public CString FinalString
		{
			get => GetProperty(ref _finalString);
			set => SetProperty(ref _finalString, value);
		}

		public BaseChargesStatListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
