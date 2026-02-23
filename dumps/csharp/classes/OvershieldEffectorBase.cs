using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OvershieldEffectorBase : gameContinuousEffector
	{
		private CHandle<gameStatsSystem> _statSystem;
		private CHandle<gameStatPoolsSystem> _poolSystem;
		private CArray<CHandle<gameStatModifierData_Deprecated>> _immunityTypes;
		private CBool _modifiersAdded;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("statSystem")] 
		public CHandle<gameStatsSystem> StatSystem
		{
			get => GetProperty(ref _statSystem);
			set => SetProperty(ref _statSystem, value);
		}

		[Ordinal(1)] 
		[RED("poolSystem")] 
		public CHandle<gameStatPoolsSystem> PoolSystem
		{
			get => GetProperty(ref _poolSystem);
			set => SetProperty(ref _poolSystem, value);
		}

		[Ordinal(2)] 
		[RED("immunityTypes")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> ImmunityTypes
		{
			get => GetProperty(ref _immunityTypes);
			set => SetProperty(ref _immunityTypes, value);
		}

		[Ordinal(3)] 
		[RED("modifiersAdded")] 
		public CBool ModifiersAdded
		{
			get => GetProperty(ref _modifiersAdded);
			set => SetProperty(ref _modifiersAdded, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public OvershieldEffectorBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
