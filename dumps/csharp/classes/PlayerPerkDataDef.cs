using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPerkDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Uint32 _woundedInstigated;
		private gamebbScriptID_Variant _dismembermentInstigated;
		private gamebbScriptID_Uint32 _entityNoticedPlayer;
		private gamebbScriptID_Float _combatStateTime;
		private gamebbScriptID_Float _leapedDistance;
		private gamebbScriptID_Vector4 _leapPosition;
		private gamebbScriptID_EntityID _leapTarget;
		private gamebbScriptID_Uint32 _usedHealingItemOrCyberware;
		private gamebbScriptID_Uint32 _startedUsingHealingItemOrCyberware;

		[Ordinal(0)] 
		[RED("WoundedInstigated")] 
		public gamebbScriptID_Uint32 WoundedInstigated
		{
			get => GetProperty(ref _woundedInstigated);
			set => SetProperty(ref _woundedInstigated, value);
		}

		[Ordinal(1)] 
		[RED("DismembermentInstigated")] 
		public gamebbScriptID_Variant DismembermentInstigated
		{
			get => GetProperty(ref _dismembermentInstigated);
			set => SetProperty(ref _dismembermentInstigated, value);
		}

		[Ordinal(2)] 
		[RED("EntityNoticedPlayer")] 
		public gamebbScriptID_Uint32 EntityNoticedPlayer
		{
			get => GetProperty(ref _entityNoticedPlayer);
			set => SetProperty(ref _entityNoticedPlayer, value);
		}

		[Ordinal(3)] 
		[RED("CombatStateTime")] 
		public gamebbScriptID_Float CombatStateTime
		{
			get => GetProperty(ref _combatStateTime);
			set => SetProperty(ref _combatStateTime, value);
		}

		[Ordinal(4)] 
		[RED("LeapedDistance")] 
		public gamebbScriptID_Float LeapedDistance
		{
			get => GetProperty(ref _leapedDistance);
			set => SetProperty(ref _leapedDistance, value);
		}

		[Ordinal(5)] 
		[RED("LeapPosition")] 
		public gamebbScriptID_Vector4 LeapPosition
		{
			get => GetProperty(ref _leapPosition);
			set => SetProperty(ref _leapPosition, value);
		}

		[Ordinal(6)] 
		[RED("LeapTarget")] 
		public gamebbScriptID_EntityID LeapTarget
		{
			get => GetProperty(ref _leapTarget);
			set => SetProperty(ref _leapTarget, value);
		}

		[Ordinal(7)] 
		[RED("UsedHealingItemOrCyberware")] 
		public gamebbScriptID_Uint32 UsedHealingItemOrCyberware
		{
			get => GetProperty(ref _usedHealingItemOrCyberware);
			set => SetProperty(ref _usedHealingItemOrCyberware, value);
		}

		[Ordinal(8)] 
		[RED("StartedUsingHealingItemOrCyberware")] 
		public gamebbScriptID_Uint32 StartedUsingHealingItemOrCyberware
		{
			get => GetProperty(ref _startedUsingHealingItemOrCyberware);
			set => SetProperty(ref _startedUsingHealingItemOrCyberware, value);
		}

		public PlayerPerkDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
