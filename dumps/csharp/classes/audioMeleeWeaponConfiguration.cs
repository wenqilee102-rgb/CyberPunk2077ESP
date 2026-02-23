using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponConfiguration : audioAudioMetadata
	{
		private audioMeleeSound _fastWhoosh;
		private audioMeleeSound _normalWhoosh;
		private audioMeleeSound _slowWhoosh;
		private audioMeleeSound _detailSound;
		private audioMeleeSound _handlingSound;
		private audioMeleeSound _equipSound;
		private audioMeleeSound _unequipSound;
		private audioMeleeSound _blockSound;
		private audioMeleeSound _parrySound;
		private CFloat _attackChargedThreshold;
		private audioMeleeSound _attackChargedSound;
		private audioMeleeSound _attackDischargedSound;
		private CHandle<audioMeleeHitTypeMeleeSoundDictionary> _meleeSoundsByHitPerMaterialType;
		private audioMeleeRigTypeMeleeWeaponConfigurationMap _meleeWeaponConfigurationsByRigTypeMap;

		[Ordinal(1)] 
		[RED("fastWhoosh")] 
		public audioMeleeSound FastWhoosh
		{
			get => GetProperty(ref _fastWhoosh);
			set => SetProperty(ref _fastWhoosh, value);
		}

		[Ordinal(2)] 
		[RED("normalWhoosh")] 
		public audioMeleeSound NormalWhoosh
		{
			get => GetProperty(ref _normalWhoosh);
			set => SetProperty(ref _normalWhoosh, value);
		}

		[Ordinal(3)] 
		[RED("slowWhoosh")] 
		public audioMeleeSound SlowWhoosh
		{
			get => GetProperty(ref _slowWhoosh);
			set => SetProperty(ref _slowWhoosh, value);
		}

		[Ordinal(4)] 
		[RED("detailSound")] 
		public audioMeleeSound DetailSound
		{
			get => GetProperty(ref _detailSound);
			set => SetProperty(ref _detailSound, value);
		}

		[Ordinal(5)] 
		[RED("handlingSound")] 
		public audioMeleeSound HandlingSound
		{
			get => GetProperty(ref _handlingSound);
			set => SetProperty(ref _handlingSound, value);
		}

		[Ordinal(6)] 
		[RED("equipSound")] 
		public audioMeleeSound EquipSound
		{
			get => GetProperty(ref _equipSound);
			set => SetProperty(ref _equipSound, value);
		}

		[Ordinal(7)] 
		[RED("unequipSound")] 
		public audioMeleeSound UnequipSound
		{
			get => GetProperty(ref _unequipSound);
			set => SetProperty(ref _unequipSound, value);
		}

		[Ordinal(8)] 
		[RED("blockSound")] 
		public audioMeleeSound BlockSound
		{
			get => GetProperty(ref _blockSound);
			set => SetProperty(ref _blockSound, value);
		}

		[Ordinal(9)] 
		[RED("parrySound")] 
		public audioMeleeSound ParrySound
		{
			get => GetProperty(ref _parrySound);
			set => SetProperty(ref _parrySound, value);
		}

		[Ordinal(10)] 
		[RED("attackChargedThreshold")] 
		public CFloat AttackChargedThreshold
		{
			get => GetProperty(ref _attackChargedThreshold);
			set => SetProperty(ref _attackChargedThreshold, value);
		}

		[Ordinal(11)] 
		[RED("attackChargedSound")] 
		public audioMeleeSound AttackChargedSound
		{
			get => GetProperty(ref _attackChargedSound);
			set => SetProperty(ref _attackChargedSound, value);
		}

		[Ordinal(12)] 
		[RED("attackDischargedSound")] 
		public audioMeleeSound AttackDischargedSound
		{
			get => GetProperty(ref _attackDischargedSound);
			set => SetProperty(ref _attackDischargedSound, value);
		}

		[Ordinal(13)] 
		[RED("meleeSoundsByHitPerMaterialType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionary> MeleeSoundsByHitPerMaterialType
		{
			get => GetProperty(ref _meleeSoundsByHitPerMaterialType);
			set => SetProperty(ref _meleeSoundsByHitPerMaterialType, value);
		}

		[Ordinal(14)] 
		[RED("meleeWeaponConfigurationsByRigTypeMap")] 
		public audioMeleeRigTypeMeleeWeaponConfigurationMap MeleeWeaponConfigurationsByRigTypeMap
		{
			get => GetProperty(ref _meleeWeaponConfigurationsByRigTypeMap);
			set => SetProperty(ref _meleeWeaponConfigurationsByRigTypeMap, value);
		}

		public audioMeleeWeaponConfiguration(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
