using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectEvents : LocomotionGroundEvents
	{
		private wCHandle<gamedataStatusEffect_Record> _statusEffectRecord;
		private wCHandle<gamedataStatusEffectPlayerData_Record> _playerStatusEffectRecordData;
		private CHandle<AnimFeature_StatusEffect> _animFeatureStatusEffect;
		private CString _statusEffectEnumName;
		private CFloat _timeInAnimState;
		private CFloat _timeInEffect;

		[Ordinal(6)] 
		[RED("statusEffectRecord")] 
		public wCHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetProperty(ref _statusEffectRecord);
			set => SetProperty(ref _statusEffectRecord, value);
		}

		[Ordinal(7)] 
		[RED("playerStatusEffectRecordData")] 
		public wCHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData
		{
			get => GetProperty(ref _playerStatusEffectRecordData);
			set => SetProperty(ref _playerStatusEffectRecordData, value);
		}

		[Ordinal(8)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetProperty(ref _animFeatureStatusEffect);
			set => SetProperty(ref _animFeatureStatusEffect, value);
		}

		[Ordinal(9)] 
		[RED("statusEffectEnumName")] 
		public CString StatusEffectEnumName
		{
			get => GetProperty(ref _statusEffectEnumName);
			set => SetProperty(ref _statusEffectEnumName, value);
		}

		[Ordinal(10)] 
		[RED("timeInAnimState")] 
		public CFloat TimeInAnimState
		{
			get => GetProperty(ref _timeInAnimState);
			set => SetProperty(ref _timeInAnimState, value);
		}

		[Ordinal(11)] 
		[RED("timeInEffect")] 
		public CFloat TimeInEffect
		{
			get => GetProperty(ref _timeInEffect);
			set => SetProperty(ref _timeInEffect, value);
		}

		public StatusEffectEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
