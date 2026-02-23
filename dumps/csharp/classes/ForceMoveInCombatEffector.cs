using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceMoveInCombatEffector : gameEffector
	{
		private CHandle<AIHumanComponent> _aiComponent;
		private CBool _commandStarted;

		[Ordinal(0)] 
		[RED("aiComponent")] 
		public CHandle<AIHumanComponent> AiComponent
		{
			get => GetProperty(ref _aiComponent);
			set => SetProperty(ref _aiComponent, value);
		}

		[Ordinal(1)] 
		[RED("commandStarted")] 
		public CBool CommandStarted
		{
			get => GetProperty(ref _commandStarted);
			set => SetProperty(ref _commandStarted, value);
		}

		public ForceMoveInCombatEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
