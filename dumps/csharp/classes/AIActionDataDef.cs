using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Int32 _ownerMeleeAttackBlockedCount;
		private gamebbScriptID_Int32 _ownerMeleeAttackParriedCount;
		private gamebbScriptID_Int32 _ownerMeleeAttackDodgedCount;
		private gamebbScriptID_Float _ownerLastAttackTimeStamp;
		private gamebbScriptID_CName _ownerLastAttackName;
		private gamebbScriptID_Bool _ownerInTumble;
		private gamebbScriptID_Bool _ownerCurrentAnimVariationSet;
		private gamebbScriptID_Variant _ownerLastAnimVariationAction;
		private gamebbScriptID_Int32 _ownerLastAnimVariation;
		private gamebbScriptID_Int32 _ownerLastBlockAnimVariation;
		private gamebbScriptID_Variant _ownerItemsToEquip;
		private gamebbScriptID_Variant _ownerItemsUnequipped;
		private gamebbScriptID_Variant _ownerItemsForceUnequipped;
		private gamebbScriptID_Variant _ownerLastEquippedItems;
		private gamebbScriptID_Float _ownerLastUnequipTimestamp;
		private gamebbScriptID_Float _ownerEquipItemTime;
		private gamebbScriptID_Float _ownerEquipDuration;
		private gamebbScriptID_Bool _dropItemOnUnequip;
		private gamebbScriptID_Bool _archetypeEffectorsApplied;
		private gamebbScriptID_Float _ownerTimeDilation;
		private gamebbScriptID_Float _ownerGlobalTimeDilation;
		private gamebbScriptID_Bool _operationHasBeenProcessed;
		private gamebbScriptID_Bool _weaponTrailInitialised;
		private gamebbScriptID_Bool _weaponTrailAborted;
		private gamebbScriptID_Variant _netrunner;
		private gamebbScriptID_Variant _netrunnerProxy;
		private gamebbScriptID_Variant _netrunnerTarget;
		private gamebbScriptID_Bool _ignoreInCombatMoveCommand;
		private gamebbScriptID_Float _avoidLOSTimeStamp;
		private gamebbScriptID_Bool _attackBlocked;
		private gamebbScriptID_Bool _attackParried;
		private gamebbScriptID_Float _lastGrenadeThrowTimestamp;

		[Ordinal(0)] 
		[RED("ownerMeleeAttackBlockedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackBlockedCount
		{
			get => GetProperty(ref _ownerMeleeAttackBlockedCount);
			set => SetProperty(ref _ownerMeleeAttackBlockedCount, value);
		}

		[Ordinal(1)] 
		[RED("ownerMeleeAttackParriedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackParriedCount
		{
			get => GetProperty(ref _ownerMeleeAttackParriedCount);
			set => SetProperty(ref _ownerMeleeAttackParriedCount, value);
		}

		[Ordinal(2)] 
		[RED("ownerMeleeAttackDodgedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackDodgedCount
		{
			get => GetProperty(ref _ownerMeleeAttackDodgedCount);
			set => SetProperty(ref _ownerMeleeAttackDodgedCount, value);
		}

		[Ordinal(3)] 
		[RED("ownerLastAttackTimeStamp")] 
		public gamebbScriptID_Float OwnerLastAttackTimeStamp
		{
			get => GetProperty(ref _ownerLastAttackTimeStamp);
			set => SetProperty(ref _ownerLastAttackTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("ownerLastAttackName")] 
		public gamebbScriptID_CName OwnerLastAttackName
		{
			get => GetProperty(ref _ownerLastAttackName);
			set => SetProperty(ref _ownerLastAttackName, value);
		}

		[Ordinal(5)] 
		[RED("ownerInTumble")] 
		public gamebbScriptID_Bool OwnerInTumble
		{
			get => GetProperty(ref _ownerInTumble);
			set => SetProperty(ref _ownerInTumble, value);
		}

		[Ordinal(6)] 
		[RED("ownerCurrentAnimVariationSet")] 
		public gamebbScriptID_Bool OwnerCurrentAnimVariationSet
		{
			get => GetProperty(ref _ownerCurrentAnimVariationSet);
			set => SetProperty(ref _ownerCurrentAnimVariationSet, value);
		}

		[Ordinal(7)] 
		[RED("ownerLastAnimVariationAction")] 
		public gamebbScriptID_Variant OwnerLastAnimVariationAction
		{
			get => GetProperty(ref _ownerLastAnimVariationAction);
			set => SetProperty(ref _ownerLastAnimVariationAction, value);
		}

		[Ordinal(8)] 
		[RED("ownerLastAnimVariation")] 
		public gamebbScriptID_Int32 OwnerLastAnimVariation
		{
			get => GetProperty(ref _ownerLastAnimVariation);
			set => SetProperty(ref _ownerLastAnimVariation, value);
		}

		[Ordinal(9)] 
		[RED("ownerLastBlockAnimVariation")] 
		public gamebbScriptID_Int32 OwnerLastBlockAnimVariation
		{
			get => GetProperty(ref _ownerLastBlockAnimVariation);
			set => SetProperty(ref _ownerLastBlockAnimVariation, value);
		}

		[Ordinal(10)] 
		[RED("ownerItemsToEquip")] 
		public gamebbScriptID_Variant OwnerItemsToEquip
		{
			get => GetProperty(ref _ownerItemsToEquip);
			set => SetProperty(ref _ownerItemsToEquip, value);
		}

		[Ordinal(11)] 
		[RED("ownerItemsUnequipped")] 
		public gamebbScriptID_Variant OwnerItemsUnequipped
		{
			get => GetProperty(ref _ownerItemsUnequipped);
			set => SetProperty(ref _ownerItemsUnequipped, value);
		}

		[Ordinal(12)] 
		[RED("ownerItemsForceUnequipped")] 
		public gamebbScriptID_Variant OwnerItemsForceUnequipped
		{
			get => GetProperty(ref _ownerItemsForceUnequipped);
			set => SetProperty(ref _ownerItemsForceUnequipped, value);
		}

		[Ordinal(13)] 
		[RED("ownerLastEquippedItems")] 
		public gamebbScriptID_Variant OwnerLastEquippedItems
		{
			get => GetProperty(ref _ownerLastEquippedItems);
			set => SetProperty(ref _ownerLastEquippedItems, value);
		}

		[Ordinal(14)] 
		[RED("ownerLastUnequipTimestamp")] 
		public gamebbScriptID_Float OwnerLastUnequipTimestamp
		{
			get => GetProperty(ref _ownerLastUnequipTimestamp);
			set => SetProperty(ref _ownerLastUnequipTimestamp, value);
		}

		[Ordinal(15)] 
		[RED("ownerEquipItemTime")] 
		public gamebbScriptID_Float OwnerEquipItemTime
		{
			get => GetProperty(ref _ownerEquipItemTime);
			set => SetProperty(ref _ownerEquipItemTime, value);
		}

		[Ordinal(16)] 
		[RED("ownerEquipDuration")] 
		public gamebbScriptID_Float OwnerEquipDuration
		{
			get => GetProperty(ref _ownerEquipDuration);
			set => SetProperty(ref _ownerEquipDuration, value);
		}

		[Ordinal(17)] 
		[RED("dropItemOnUnequip")] 
		public gamebbScriptID_Bool DropItemOnUnequip
		{
			get => GetProperty(ref _dropItemOnUnequip);
			set => SetProperty(ref _dropItemOnUnequip, value);
		}

		[Ordinal(18)] 
		[RED("archetypeEffectorsApplied")] 
		public gamebbScriptID_Bool ArchetypeEffectorsApplied
		{
			get => GetProperty(ref _archetypeEffectorsApplied);
			set => SetProperty(ref _archetypeEffectorsApplied, value);
		}

		[Ordinal(19)] 
		[RED("ownerTimeDilation")] 
		public gamebbScriptID_Float OwnerTimeDilation
		{
			get => GetProperty(ref _ownerTimeDilation);
			set => SetProperty(ref _ownerTimeDilation, value);
		}

		[Ordinal(20)] 
		[RED("ownerGlobalTimeDilation")] 
		public gamebbScriptID_Float OwnerGlobalTimeDilation
		{
			get => GetProperty(ref _ownerGlobalTimeDilation);
			set => SetProperty(ref _ownerGlobalTimeDilation, value);
		}

		[Ordinal(21)] 
		[RED("operationHasBeenProcessed")] 
		public gamebbScriptID_Bool OperationHasBeenProcessed
		{
			get => GetProperty(ref _operationHasBeenProcessed);
			set => SetProperty(ref _operationHasBeenProcessed, value);
		}

		[Ordinal(22)] 
		[RED("weaponTrailInitialised")] 
		public gamebbScriptID_Bool WeaponTrailInitialised
		{
			get => GetProperty(ref _weaponTrailInitialised);
			set => SetProperty(ref _weaponTrailInitialised, value);
		}

		[Ordinal(23)] 
		[RED("weaponTrailAborted")] 
		public gamebbScriptID_Bool WeaponTrailAborted
		{
			get => GetProperty(ref _weaponTrailAborted);
			set => SetProperty(ref _weaponTrailAborted, value);
		}

		[Ordinal(24)] 
		[RED("netrunner")] 
		public gamebbScriptID_Variant Netrunner
		{
			get => GetProperty(ref _netrunner);
			set => SetProperty(ref _netrunner, value);
		}

		[Ordinal(25)] 
		[RED("netrunnerProxy")] 
		public gamebbScriptID_Variant NetrunnerProxy
		{
			get => GetProperty(ref _netrunnerProxy);
			set => SetProperty(ref _netrunnerProxy, value);
		}

		[Ordinal(26)] 
		[RED("netrunnerTarget")] 
		public gamebbScriptID_Variant NetrunnerTarget
		{
			get => GetProperty(ref _netrunnerTarget);
			set => SetProperty(ref _netrunnerTarget, value);
		}

		[Ordinal(27)] 
		[RED("ignoreInCombatMoveCommand")] 
		public gamebbScriptID_Bool IgnoreInCombatMoveCommand
		{
			get => GetProperty(ref _ignoreInCombatMoveCommand);
			set => SetProperty(ref _ignoreInCombatMoveCommand, value);
		}

		[Ordinal(28)] 
		[RED("avoidLOSTimeStamp")] 
		public gamebbScriptID_Float AvoidLOSTimeStamp
		{
			get => GetProperty(ref _avoidLOSTimeStamp);
			set => SetProperty(ref _avoidLOSTimeStamp, value);
		}

		[Ordinal(29)] 
		[RED("attackBlocked")] 
		public gamebbScriptID_Bool AttackBlocked
		{
			get => GetProperty(ref _attackBlocked);
			set => SetProperty(ref _attackBlocked, value);
		}

		[Ordinal(30)] 
		[RED("attackParried")] 
		public gamebbScriptID_Bool AttackParried
		{
			get => GetProperty(ref _attackParried);
			set => SetProperty(ref _attackParried, value);
		}

		[Ordinal(31)] 
		[RED("lastGrenadeThrowTimestamp")] 
		public gamebbScriptID_Float LastGrenadeThrowTimestamp
		{
			get => GetProperty(ref _lastGrenadeThrowTimestamp);
			set => SetProperty(ref _lastGrenadeThrowTimestamp, value);
		}

		public AIActionDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
