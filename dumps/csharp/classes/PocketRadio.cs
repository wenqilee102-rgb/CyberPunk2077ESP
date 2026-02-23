using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PocketRadio : IScriptable
	{
		private wCHandle<PlayerPuppet> _player;
		private CInt32 _station;
		private CInt32 _selectedStation;
		private CInt32 _toggledStation;
		private CArray<CBool> _restrictions;
		private CBool _isConditionRestricted;
		private CBool _isUnlockDelayRestricted;
		private CBool _isRestrictionOverwritten;
		private CBool _isOn;
		private CHandle<PocketRadioQuestContentLockListener> _questContentLockListener;
		private CFloat _radioPressTime;
		private CBool _isInMetro;
		private CHandle<RadioportSettingsListener> _settings;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("station")] 
		public CInt32 Station
		{
			get => GetProperty(ref _station);
			set => SetProperty(ref _station, value);
		}

		[Ordinal(2)] 
		[RED("selectedStation")] 
		public CInt32 SelectedStation
		{
			get => GetProperty(ref _selectedStation);
			set => SetProperty(ref _selectedStation, value);
		}

		[Ordinal(3)] 
		[RED("toggledStation")] 
		public CInt32 ToggledStation
		{
			get => GetProperty(ref _toggledStation);
			set => SetProperty(ref _toggledStation, value);
		}

		[Ordinal(4)] 
		[RED("restrictions")] 
		public CArray<CBool> Restrictions
		{
			get => GetProperty(ref _restrictions);
			set => SetProperty(ref _restrictions, value);
		}

		[Ordinal(5)] 
		[RED("isConditionRestricted")] 
		public CBool IsConditionRestricted
		{
			get => GetProperty(ref _isConditionRestricted);
			set => SetProperty(ref _isConditionRestricted, value);
		}

		[Ordinal(6)] 
		[RED("isUnlockDelayRestricted")] 
		public CBool IsUnlockDelayRestricted
		{
			get => GetProperty(ref _isUnlockDelayRestricted);
			set => SetProperty(ref _isUnlockDelayRestricted, value);
		}

		[Ordinal(7)] 
		[RED("isRestrictionOverwritten")] 
		public CBool IsRestrictionOverwritten
		{
			get => GetProperty(ref _isRestrictionOverwritten);
			set => SetProperty(ref _isRestrictionOverwritten, value);
		}

		[Ordinal(8)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetProperty(ref _isOn);
			set => SetProperty(ref _isOn, value);
		}

		[Ordinal(9)] 
		[RED("questContentLockListener")] 
		public CHandle<PocketRadioQuestContentLockListener> QuestContentLockListener
		{
			get => GetProperty(ref _questContentLockListener);
			set => SetProperty(ref _questContentLockListener, value);
		}

		[Ordinal(10)] 
		[RED("radioPressTime")] 
		public CFloat RadioPressTime
		{
			get => GetProperty(ref _radioPressTime);
			set => SetProperty(ref _radioPressTime, value);
		}

		[Ordinal(11)] 
		[RED("isInMetro")] 
		public CBool IsInMetro
		{
			get => GetProperty(ref _isInMetro);
			set => SetProperty(ref _isInMetro, value);
		}

		[Ordinal(12)] 
		[RED("settings")] 
		public CHandle<RadioportSettingsListener> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		public PocketRadio(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
