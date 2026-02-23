using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JuggernautEffector : gameContinuousEffector
	{
		private CBool _modifiersAdded;
		private CHandle<gameStatPoolsSystem> _poolSystem;
		private CHandle<gameStatusEffectSystem> _statusEffectSystem;

		[Ordinal(0)] 
		[RED("modifiersAdded")] 
		public CBool ModifiersAdded
		{
			get => GetProperty(ref _modifiersAdded);
			set => SetProperty(ref _modifiersAdded, value);
		}

		[Ordinal(1)] 
		[RED("poolSystem")] 
		public CHandle<gameStatPoolsSystem> PoolSystem
		{
			get => GetProperty(ref _poolSystem);
			set => SetProperty(ref _poolSystem, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectSystem")] 
		public CHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetProperty(ref _statusEffectSystem);
			set => SetProperty(ref _statusEffectSystem, value);
		}

		public JuggernautEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
