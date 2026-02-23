using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerWeaponHandlingModifiers : IScriptable
	{
		private wCHandle<PlayerPuppet> _player;
		private CName _opSymbol;
		private CArray<CHandle<gameConstantStatModifierData_Deprecated>> _recoilGroup;
		private CArray<CHandle<gameConstantStatModifierData_Deprecated>> _timeOutGroup;
		private CArray<CHandle<gameConstantStatModifierData_Deprecated>> _multSwayGroup;
		private CArray<CHandle<gameConstantStatModifierData_Deprecated>> _addSwayGroup;
		private CArray<CHandle<gameConstantStatModifierData_Deprecated>> _spreadGroup;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("opSymbol")] 
		public CName OpSymbol
		{
			get => GetProperty(ref _opSymbol);
			set => SetProperty(ref _opSymbol, value);
		}

		[Ordinal(2)] 
		[RED("recoilGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> RecoilGroup
		{
			get => GetProperty(ref _recoilGroup);
			set => SetProperty(ref _recoilGroup, value);
		}

		[Ordinal(3)] 
		[RED("timeOutGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> TimeOutGroup
		{
			get => GetProperty(ref _timeOutGroup);
			set => SetProperty(ref _timeOutGroup, value);
		}

		[Ordinal(4)] 
		[RED("multSwayGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> MultSwayGroup
		{
			get => GetProperty(ref _multSwayGroup);
			set => SetProperty(ref _multSwayGroup, value);
		}

		[Ordinal(5)] 
		[RED("addSwayGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> AddSwayGroup
		{
			get => GetProperty(ref _addSwayGroup);
			set => SetProperty(ref _addSwayGroup, value);
		}

		[Ordinal(6)] 
		[RED("spreadGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> SpreadGroup
		{
			get => GetProperty(ref _spreadGroup);
			set => SetProperty(ref _spreadGroup, value);
		}

		public PlayerWeaponHandlingModifiers(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
