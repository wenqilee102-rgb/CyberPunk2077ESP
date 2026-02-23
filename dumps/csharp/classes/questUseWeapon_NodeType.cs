using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUseWeapon_NodeType : questIItemManagerNodeType
	{
		private CEnum<questWeaponUsageType> _usageType;
		private CHandle<questUniversalRef> _objectRef;
		private CName _overrideShootEffect;
		private CName _weaponSlotName;
		private TweakDBID _attackTDBID;

		[Ordinal(0)] 
		[RED("usageType")] 
		public CEnum<questWeaponUsageType> UsageType
		{
			get => GetProperty(ref _usageType);
			set => SetProperty(ref _usageType, value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(2)] 
		[RED("overrideShootEffect")] 
		public CName OverrideShootEffect
		{
			get => GetProperty(ref _overrideShootEffect);
			set => SetProperty(ref _overrideShootEffect, value);
		}

		[Ordinal(3)] 
		[RED("weaponSlotName")] 
		public CName WeaponSlotName
		{
			get => GetProperty(ref _weaponSlotName);
			set => SetProperty(ref _weaponSlotName, value);
		}

		[Ordinal(4)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetProperty(ref _attackTDBID);
			set => SetProperty(ref _attackTDBID, value);
		}

		public questUseWeapon_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
